using System;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace ZiggeoDemoApp.Controllers
{
    // https://ziggeo.com/docs/sdks/server-side/csharp/effect-profiles
    // [Route("[controller]")] // Not mandatory as douing the same thing
    public class ProfileController : Controller
    {
        private readonly ILogger<ProfileController> _logger;
        private readonly Ziggeo _ziggeo;

        public ProfileController(ILogger<ProfileController> logger)
        {
            _logger = logger;
            _ziggeo = new Ziggeo(Config.ApiKey, Config.PrivateKey, Config.EncryptionKey);
        }
        
        /// <summary>Will list all profiles</summary>
        /// <param name="limit">limited pfofiles</param>
        /// <param name="skip">skip number of profiles from the beginning</param>
        /// <param name="reverse">will reverse list</param>
        public IActionResult Index(int limit = 5, int skip = 0, bool reverse = false)
        {
            ProfileViewModel profileViewModel = new ProfileViewModel();
            Dictionary<string, string> profilesQuery = new Dictionary<string, string>()
            {
                {"limit", limit.ToString()}, // Limit the number of returned effect profiles. Can be set up to 100.
                {"skip", skip.ToString()}, // Skip the first [n] entries.
                {"reverse", reverse.ToString()},  // Reverse the order in which effect profiles are returned.
                // This method returns JSON
            };
            
            dynamic allProfiles = _ziggeo.effectProfiles().index(profilesQuery);
            ViewData["allProfiles"] = allProfiles;
            
            profileViewModel.allProfiles = allProfiles;
            return View(profileViewModel);
        }
        
        /// <summary>
        /// Will show profile details
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult ViewDetails(string token)
        {
            ProfileViewModel profileViewModel = new ProfileViewModel();
            
            dynamic profile = _ziggeo.effectProfiles().get(token);
            
            profileViewModel.profile = profile;
            return View(profileViewModel);
        }
        
        /// <summary>
        /// Create a new profile for your application
        /// you can pass 3 parameters, but also can imprvove code by adding missing parameters
        /// like states, tags
        /// </summary>
        /// <param name="limit">limited pfofiles</param>
        /// <param name="skip">skip number of profiles from the beginning</param>
        /// <param name="reverse">will reverse list</param>
        public IActionResult Create(int limit = 5, int skip = 0, bool reverse = false)
        {
            ProfileCreateModel VideoData = new ProfileCreateModel();
            // return Json("We have success!!");
            return View(VideoData);
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
                return Redirect("/Profile");
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
                _ziggeo.effectProfiles().delete(token);
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
                    {"message", "We have some exception IActionResult Delete: " + err.Message}
                };
                return Json(responseJSON);
            }
        }

        /// <summary>
        /// Will add new Profile with provided input and return JSON
        /// </summary>
        /// <param name="model"></param>
        /// <returns>JSON</returns>
        [HttpPost]
        public IActionResult Add([FromBody]ProfileCreateModel model)
        {
            Console.WriteLine("Does our model is valid? >> {0}, Model is: {1}", ModelState.IsValid, model);
            Dictionary<string, string> responseJSON;
            if (ModelState.IsValid)
            {
                Dictionary<string, string> profileQuery = new Dictionary<string, string>()
                {
                    { "key", model.profileKey },
                    { "title", model.profileTitle },
                    { "default_effect", model.isDefault.ToString().ToUpper() }
                };
                
                try
                {
                    _ziggeo.effectProfiles().create(profileQuery);
                    responseJSON = new Dictionary<string, string>()
                    {
                        {"success", "true"},
                        {"message", "All success"}
                    };
                    return Json(responseJSON);
                }
                catch (Exception err)
                { 
                    responseJSON = new Dictionary<string, string>()
                    {
                        {"success", "false"},
                        {"message", "We have some exception (Profile/Add): " + err.Message}
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
        /// Will update profile and response as a JSON
        /// </summary>
        /// <param name="model"></param>
        /// <returns>Json</returns>
        [HttpPost]
        public IActionResult Edit([FromBody]ProfileUpdateModel model)
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
                        {"message", "We have some exception (Profile/Edit): " + err.Message}
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
    }
}
