using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
namespace Delete_all_videos
{
    public class Delete_All_Videos
    {
        public static void Main(string[] args)
        {

            Ziggeo ziggeo = new Ziggeo("APP_TOKEN", "PRIVATE_KEY", "ENCRYPTION_KEY");

            dynamic AllVideos = JsonConvert.DeserializeObject(ziggeo.videos().index());

            if (AllVideos != null)
            {
                foreach (var item in AllVideos)
                {

                    dynamic videoToDelete = JsonConvert.DeserializeObject(ziggeo.videos().get(item.token));

                    String file_name = videoToDelete.defaultstream.video_token;

                    System.Console.WriteLine("Deleting" + file_name);

                    ziggeo.videos().delete(item.token);
                }
            }
        }

    }
}