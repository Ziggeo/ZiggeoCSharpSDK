using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace List_effect_profiles
{
    public class List_profile_profiles
    {
        public static void Main(string[] args)
        {

            Ziggeo ziggeo = new Ziggeo("APP_TOKEN", "PRIVATE_KEY", "ENCRYPTION_KEY");

            dynamic AllProfiles = JsonConvert.DeserializeObject(ziggeo.effectProfiles().index());

            foreach (var item in AllProfiles)
            {

                System.Console.WriteLine("Listing" + item.token);

            }
        }
    }
}
