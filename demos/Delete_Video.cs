using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace Delete_Video
{
    public class Delete_Video
    {
        public static void Main(string[] args)
        {

            Ziggeo ziggeo = new Ziggeo("APP_TOKEN", "PRIVATE_KEY", "ENCRYPTION_KEY");

            string VIDEO_TOKEN = "YOUR_VIDEO_TOKEN";

            System.Console.WriteLine("Deleting" + VIDEO_TOKEN);

            ziggeo.videos().delete("Video_TOKEN");

        }

    }
}