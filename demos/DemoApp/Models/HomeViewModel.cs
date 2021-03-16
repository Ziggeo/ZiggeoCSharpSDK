using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using Newtonsoft.Json;

namespace ZiggeoDemoApp
{
    public class HomeViewModel
    {
        public Dictionary<string, Dictionary<string, string>> routes { get; set; }
    }
}
