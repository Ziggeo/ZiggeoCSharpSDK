using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace Download_image
{
    public class Download_image
    {
		public static void Main(string[] args)
		{

			Ziggeo ziggeo = new Ziggeo("APP_TOKEN", "PRIVATE_KEY", "ENCRYPTION_KEY");

			dynamic videoImageToDownload = JsonConvert.DeserializeObject(ziggeo.videos().get("Video_TOKEN"));

            string Imagefile_name = videoImageToDownload.defaultstream.video_token;

            var Imagefile_content = ziggeo.videos().download_image(videoImageToDownload);

            string Imagefile_path = "your file path" + Imagefile_name;

			File.WriteAllText(Imagefile_path, Imagefile_content);

		}
    }
}
