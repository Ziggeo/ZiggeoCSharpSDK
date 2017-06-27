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


            while (true)
            {
                dynamic AllVideos = JsonConvert.DeserializeObject(ziggeo.videos().index());

                if (AllVideos.count() == 0)
                    break;

                foreach (var item in AllVideos)
                {

                    System.Console.WriteLine("Deleting" + item.token);

                    ziggeo.videos().delete(item.token);
                }
            }

        }
    }
}
