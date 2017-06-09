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

            dynamic videoToDownload = JsonConvert.DeserializeObject(ziggeo.videos().get("Video_TOKEN"));

            string file_name = videoToDownload.defaultstream.video_token;

            System.Console.WriteLine("Deleting" + file_name);

            ziggeo.videos().delete("Video_TOKEN");

        }

    }
}