using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using Newtonsoft.Json;

namespace ZiggeoDemoApp
{
    public class ProfileViewModel
    {
        public dynamic allVideos;
        public dynamic allProfiles;
        public dynamic profile;
    }
    
    public class ProfileCreateModel
    {
        public readonly bool isCreate = true;
        
        [Required]
        public string profileKey { get; set; }

        [Required]
        public string profileTitle { get; set; }

        public bool isDefault { get; set; } = false;
    }
    
    public class ProfileUpdateModel
    {
        public readonly bool isCreate = false;
        
        [Required]
        public string profileToken { get; set; }
        
        [Required]
        public bool isDefault { get; set; }
        
        public string profileTitle { get; set; }
    }
}
