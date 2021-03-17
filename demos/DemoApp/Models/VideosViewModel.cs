using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.FileProviders;
using Newtonsoft.Json;

namespace ZiggeoDemoApp
{
    public class VideosViewModel
    {
        public dynamic allVideos;
        public dynamic singleVideo;
        public int limitCount;
        public int allVideosCount;
        public dynamic stats;
        public bool isResponseIsObject = true;
    }
    
    public class VideosCreateModel
    {
        public readonly bool isCreate = true;
        public int minDuration { get; set; } = 0;
        public int maxDuration { get; set; } = 0;
        public string tags { get; set; } = "";
        public string key { get; set; } = "";
        public string volatileVideo { get; set; } = "off";
        
        [Required]
        public IFormFile file { get; set; }
    }
    
    public class VideosUpdateModel
    {
        public readonly bool isCreate = false;
        
       [Required]
        public string videoToken { get; set; }
        
        public string key { get; set; }
        public string tags { get; set; }
        public string minDuration { get; set; }
        public string maxDuration { get; set; }
        
        public string expireOn { get; set; }
        public string expirationDays { get; set; }
        public string volatileVideo { get; set; }
    }
}
