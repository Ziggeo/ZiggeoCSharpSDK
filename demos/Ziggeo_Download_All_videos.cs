using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;


namespace Download_All_Videos
{
	public class Download_All_Videos
	{
        public static void Main(string[] args)
        {

            Ziggeo ziggeo = new Ziggeo("APP_TOKEN", "PRIVATE_KEY", "ENCRYPTION_KEY");

            dynamic AllVideos = JsonConvert.DeserializeObject(ziggeo.videos().index());

            if (AllVideos != null)
            {
                foreach (var item in AllVideos)
                {

                    dynamic videoToDownload = JsonConvert.DeserializeObject(ziggeo.videos().get(item.token));

                    string file_extension = videoToDownload.defaultstream.video_type;

                    string file_name = videoToDownload.defaultstream.video_token + "." + file_extension;


                    System.Console.WriteLine("downloading" + file_name);


                    var file_content = ziggeo.videos().download_video(videoToDownload);

                    string file_path = "your file path" + file_name;

                    File.WriteAllText(file_path, (file_content));
                }
            }
        }

	}
}

