using System;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace ZiggeoDemoApp.Controllers
{
    // https://ziggeo.com/docs/sdks/server-side/csharp/effect-profiles
    // [Route("[controller]")] // Not mandatory as douing the same thing
    public class VideosController : Controller
    {
        private readonly ILogger<ProfileController> _logger;
        private readonly Ziggeo _ziggeo;

        public VideosController(ILogger<ProfileController> logger)
        {
            _logger = logger;
            _ziggeo = new Ziggeo(Config.ApiKey, Config.PrivateKey, Config.EncryptionKey);
        }
        
        /// <summary>Will list all videos</summary>
        /// <param name="limit">Limit the number of returned videos. Can be set up to 100.</param>
        /// <param name="skip">Skip the first [n] entries.</param>
        /// <param name="reverse">Reverse the order in which videos are returned.</param>
        /// <param name="states">Filter videos by state</param>
        /// <param name="tags">Filter the search result to certain tags, encoded as a comma-separated string</param>
        public IActionResult Index(int limit = 5, int skip = 0, bool reverse = false, string states = "", string tags = "")
        {
            VideosViewModel videoModel = new VideosViewModel();
            Dictionary<string, string> dataQuery = new Dictionary<string, string>()
            {
                {"limit", limit.ToString()},
                {"skip", skip.ToString()},
                {"reverse", reverse.ToString()},
                {"states", states.ToString()},
                {"tags", tags.ToString()},
                // This method returns JSON
            };
            
            Dictionary<string, string> countDataQuery = new Dictionary<string, string>()
            {
                {"states", states.ToString()},
                {"tags", tags.ToString()},
                // This method returns JSON
            };

            
            dynamic allVideos = _ziggeo.videos().index(dataQuery);
            ViewData["allVideos"] = allVideos;
            ViewData["limitCount"] = limit;
            ViewData["allVideosCount"] = _ziggeo.videos().count(countDataQuery);
            
            videoModel.allVideos = allVideos;
            return View(videoModel);
        }
        
        /// <summary>
        /// Will show profile details
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult ViewSingle(string token)
        {
            VideosViewModel model = new VideosViewModel();
            
            dynamic video = _ziggeo.videos().get(token);
            
            model.singleVideo = video;
            return View(model);
        }
        
        /// <summary>
        /// Will show profile details
        /// </summary>
        /// <param name="tokens"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult ViewBulk(string tokens)
        {
            string[] textSplit = tokens.Split(",");
            if (textSplit.Length > 100 || textSplit.First().Length > 50)
                throw new Exception("Token not correct, please be sure provided token is comma separated");

            VideosViewModel videoModel = new VideosViewModel();
            
            Dictionary<string, string> viewSelectedDataQuery = new Dictionary<string, string>()
            {
                // Comma-separated list with the desired videos tokens or keys (Limit: 100 tokens or keys).
                {"tokens_or_keys", tokens},
                // This method returns JSON
            };
            
            dynamic videos = _ziggeo.videos().get_bulk(viewSelectedDataQuery);
            
            videoModel.allVideos = videos;
            return View(videoModel);
        }
        
        /// <summary>
        /// Will Creatre a new video
        /// </summary>
        public IActionResult Create()
        {
            VideosCreateModel model = new VideosCreateModel();
            return View(model);
        }
        
        /// <summary>
        /// Will add new Profile with provided input and return JSON
        /// </summary>
        /// <param name="model"></param>
        /// <returns>JSON</returns>
        [HttpPost]
        [RequestSizeLimit(5*1024*1024)] // // set the maximum file size limit to 5 MB
        public async Task<IActionResult> Create([FromForm] VideosCreateModel model)
        {
            var file = model.file;
            // string fileName = $"{env.WebRootPath}\\{file.FileName}";
            // Name, FileName, Length, ContentType, Headers, ContentDisposition
            // Console.WriteLine("Does our model is valid? >> {0}, File is : {3}, File name is: {1}; Content: {2}", ModelState.IsValid, file.FileName, file.Length, file);
            Dictionary<string, string> responseJSON;
            if (ModelState.IsValid)
            {
                Dictionary<string, string> videoDataQuery = new Dictionary<string, string>();
                // videoDataQuery["file"] = file.OpenReadStream().ToString();
                if (model.maxDuration > 0)
                {
                    videoDataQuery["max_duration"] = model.maxDuration.ToString();
                }
                if (model.minDuration > 0)
                {
                    videoDataQuery["min_duration"] = model.minDuration.ToString();
                }
                
                // Console.WriteLine("Yes Model is valid >> File: {3} Tags: {0}, Key: {1} and volatileVideo: {2} ",  model.tags, model.key, model.volatileVideo, file.Name);
                
                if ( model.tags != null)
                {
                    if (model.tags.Length > 0)
                        videoDataQuery["tags"] = model.tags;
                }
                if (model.key != null)
                {
                    if (model.key.Length > 0)
                        videoDataQuery["key"] = model.key;
                }
                
                videoDataQuery["volatile"] = model.volatileVideo == "on" ? "true" : "false";

                try
                {
                    dynamic response = _ziggeo.videos().create(videoDataQuery, file.FileName);
                    
                    Console.WriteLine("RESPONSE:  {0}", response);
                    
                    string token = response["token"];
                    string image_url = response["default_stream"]["embed_image_url"];
                    string video_url = response["embed_video_url"];
                    responseJSON = new Dictionary<string, string>()
                    {
                        {"success", "true"},
                        {"message", "All success"},
                        {"token", token},
                        {"embedImage", image_url},
                        {"embedVideo", video_url}
                    };
                    return Json(responseJSON);
                }
                catch (Exception err)
                { 
                    responseJSON = new Dictionary<string, string>()
                    {
                        {"success", "false"},
                        {"message", "We have some exception (async Task<IActionResult> Videos/Create): " + err.Message}
                    };
                }
            }
            else
            {
                responseJSON = new Dictionary<string, string>()
                {
                    {"success", "false"},
                    {"message", "Has validation errors count > " + ModelState.ErrorCount }
                };
            }
            return Json(responseJSON);
        }
        
        /// <summary>
        /// Will show form to update profided token
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        public IActionResult Update(string token = null)
        {
            // Token as query is required
            if (string.IsNullOrEmpty(token))
                return Redirect("/Videos");
            ProfileUpdateModel model = new ProfileUpdateModel();
            dynamic profile = _ziggeo.effectProfiles().get(token);
            // if (profile == null)
            // {
            //     return Redirect("/Profile");
            // }
            // else
            // {
                model.profileToken = profile.token;
                model.isDefault = profile.default_effect;
            // }
            
            /*
             * { "volatile": false, "token": "5789487e5788f584aae6af9a0776c44f",
                  "key": "Incidunt veniam", "title": "Est similique lore",
                  "default_effect": false, "type": "ApiEffectProfile", "created": 1608790154, "owned": false
                }
             */
            Console.WriteLine("Returned profile is >> {0}", profile);

            return View(model);
        }
        
        /// <summary>
        /// Will delete Profile token
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Delete(string token)
        {
            try
            {
                _ziggeo.videos().delete(token);
                Dictionary<string, string> responseJSON = new Dictionary<string, string>()
                {
                    {"success", "true"},
                    {"message", "All success"}
                };
                return Json(responseJSON);
            }
            catch (Exception err)
            {
                Dictionary<string, string> responseJSON = new Dictionary<string, string>()
                {
                    {"success", "false"},
                    {"message", "We have some exception (Videos/Delete): " + err.Message}
                };
                return Json(responseJSON);
            }
        }
        
        /// <summary>
        /// Will update profile and response as a JSON
        /// </summary>
        /// <param name="model"></param>
        /// <returns>Json</returns>
        [HttpPost]
        public IActionResult Update([FromBody]ProfileUpdateModel model)
        {
            string profileToken = model.profileToken;
            bool isDefault = (bool)model.isDefault;
            Console.WriteLine("After submit to edit :: Token: {0} Is Default: {1} isValid: {2}", profileToken, isDefault, ModelState.IsValid);
            Dictionary<string, string> responseJSON;
            if (ModelState.IsValid)
            {
                Dictionary<string, string> queryData = new Dictionary<string, string>()
                {
                    {"default_effect", isDefault.ToString().ToUpper()}
                };
                try
                {
                    _ziggeo.effectProfiles().update(profileToken, queryData);
                    responseJSON = new Dictionary<string, string>()
                    {
                        {"success", "true"},
                        {"message", "Profile with token: " + profileToken +" was successfully updated" }
                    };
                }
                catch (Exception err)
                { 
                    responseJSON = new Dictionary<string, string>()
                    {
                        {"success", "false"},
                        {"message", "We have some exception (Videos/Update): " + err.Message}
                    };
                }
            }
            else
            {
                responseJSON = new Dictionary<string, string>()
                {
                    {"success", "false"},
                    {"message", "Has validation errors count > " + ModelState.ErrorCount }
                };
            }

            return Json(responseJSON);
        }
        
        /// <summary>
        /// Will show profile details
        /// </summary>
        /// <param name="tokens"></param>
        /// <param name="summarized"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult UpdateBulk(string tokens, bool summarized = true)
        {
            string[] textSplit = tokens.Split(",");
            if (textSplit.Length > 100 || textSplit.First().Length > 50)
                throw new Exception("Token not correct, please be sure provided token is comma separated");

            VideosViewModel videoModel = new VideosViewModel();
            
            Dictionary<string, string> viewSelectedDataQuery = new Dictionary<string, string>()
            {
                // Comma-separated list with the desired videos tokens or keys (Limit: 100 tokens or keys).
                {"tokens_or_keys", tokens},
                {"summarize", summarized ? "true" : "false"}
                // This method returns JSON
            };
            // viewSelectedDataQuery.Add("summarize", true.ToString());
            
            videoModel.stats = _ziggeo.videos().stats_bulk(viewSelectedDataQuery);
            
            return View(videoModel);
        }

        
        /// <summary>
        /// Will add new Profile with provided input and return JSON
        /// </summary>
        /// <param name="token"></param>
        /// <returns>JSON</returns>
        public IActionResult DownloadVideo(string token)
        {
            Dictionary<string, string> responseJSON;
            Dictionary<string, string> dataQuery = new Dictionary<string, string>()
            {
                { "token_or_key", token },
            };

            Stream stream = _ziggeo.videos().download_video(token);
            
            return File(stream, "video/mp4");
        }
        
        /// <summary>
        /// Will add new Profile with provided input and return JSON
        /// </summary>
        /// <param name="token"></param>
        /// <returns>JSON</returns>
        public IActionResult DownloadImage(string token)
        {
            Dictionary<string, string> responseJSON;
            Dictionary<string, string> dataQuery = new Dictionary<string, string>()
            {
                { "token_or_key", token },
            };

            Stream stream = _ziggeo.videos().download_image(token);
            
            return File(stream, "image/jpeg");
        }

        /// <summary>
        /// Will add new Profile with provided input and return JSON
        /// </summary>
        /// <param name="token"></param>
        /// <returns>JSON</returns>
        public IActionResult GetStat(string token)
        {
            VideosViewModel model = new VideosViewModel();

            model.isResponseIsObject = false;
            model.singleVideo = _ziggeo.videos().get_stats(token);
            
            return View("ViewSingle", model);
        }
        
        
        /// <summary>
        /// Will show profile details
        /// </summary>
        /// <param name="tokens"></param>
        /// <param name="summarized"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult StatsBulk(string tokens, bool summarized = true)
        {
            string[] textSplit = tokens.Split(",");
            if (textSplit.Length > 100 || textSplit.First().Length > 50)
                throw new Exception("Token not correct, please be sure provided token is comma separated");

            VideosViewModel videoModel = new VideosViewModel();
            
            Dictionary<string, string> viewSelectedDataQuery = new Dictionary<string, string>()
            {
                // Comma-separated list with the desired videos tokens or keys (Limit: 100 tokens or keys).
                {"tokens_or_keys", tokens},
                {"summarize", summarized ? "true" : "false"}
                // This method returns JSON
            };
            // viewSelectedDataQuery.Add("summarize", true.ToString());
            
            videoModel.stats = _ziggeo.videos().stats_bulk(viewSelectedDataQuery);
            
            return View(videoModel);
        }
    }
}
