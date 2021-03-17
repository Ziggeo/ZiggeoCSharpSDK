using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
namespace expiration_days
{
    public class Expiration_Days
    {
        public static void Main(string[] args)
        {
            Ziggeo ziggeo = new Ziggeo("APP_TOKEN", "PRIVATE_KEY", "ENCRYPTION_KEY");

            Dictionary<string, string> dict = new Dictionary<string, string>()
                {
                    {"expiration_days","Number_OF_EXPIRARION_DAYS"},
                };

            ziggeo.videos().update("Video_TOKEN", dict);

            System.Console.WriteLine("Your video has been updated!!");

        }
    }
}
