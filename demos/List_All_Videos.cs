using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace list_all_videos
{
    public class List_All_Videos
    {
        public static void Main(string[] args)
        {

            Ziggeo ziggeo = new Ziggeo("APP_TOKEN", "PRIVATE_KEY", "ENCRYPTION_KEY");

            dynamic AllVideos = JsonConvert.DeserializeObject(ziggeo.videos().index());

            foreach (var item in AllVideos)
            {

                System.Console.WriteLine("Listing" + item.token + "/" + item.key);

            }
        }

    }

}
    

