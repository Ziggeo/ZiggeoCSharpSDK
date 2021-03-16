using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace Add_effect_Profile
{
    public class Add_Effect_Profile
    {
        public static void Main(string[] args)
        {
            Ziggeo ziggeo = new Ziggeo("APP_TOKEN", "PRIVATE_KEY", "ENCRYPTION_KEY");

            Dictionary<string, string> profile = new Dictionary<string, string>()
                {
                    {"key","YOUR_EFFECT_PROFILE_KEY"},
                    {"title","YOUR_EFFECT_PROFILE_TITLE" },
                };

             ziggeo.effectProfiles().create(profile);
             System.Console.WriteLine("Effect Profile has been created!!");

        }
    }

}