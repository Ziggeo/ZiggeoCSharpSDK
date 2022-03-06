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
			string app_token = args[0];
			string private_key = args[1];
			string video_token = args[2];

			Ziggeo ziggeo = new Ziggeo(app_token, private_key, "");

			var image = ziggeo.videos().download_image(video_token);

			string image_file_name = "poster_image.jpg";

			var image_file = File.Create(image_file_name);

			image.CopyTo(image_file);
			image.Close();
		}
	}
}