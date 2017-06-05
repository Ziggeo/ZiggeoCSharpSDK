using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;


namespace download
{
    public class Download_video
    {
			public static void Main(string[] args)
			{

				Ziggeo ziggeo = new Ziggeo("APP_TOKEN", "PRIVATE_KEY", "ENCRYPTION_KEY");

				dynamic videoToDownload = JsonConvert.DeserializeObject(ziggeo.videos().get("Video_TOKEN"));

				string file_extension = videoToDownload.defaultstream.video_type;

				string file_name = videoToDownload.defaultstream.video_token + "." + file_extension;

				var file_content = ziggeo.videos().download_video(videoToDownload);

				string file_path = "your file path" + file_name;

				File.WriteAllText(file_path, file_content);


			}
           
    }
}





