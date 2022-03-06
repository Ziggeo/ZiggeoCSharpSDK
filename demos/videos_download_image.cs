using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
/*
	This script will show you how you can download the video

	Parameters you need to pass:
	1. app_token
	2. private_key
	3. video_token
	4. filename
*/
namespace Videos_Download_Image
{
	public class Videos_Download_Image
	{
		public static void Main(string[] args)
		{
			string app_token = args[0];
			string private_key = args[1];
			string video_token = args[2];
			string filename = args[3];

			Ziggeo ziggeo = new Ziggeo(app_token, private_key, "");

			var image = ziggeo.videos().download_image(video_token);

			var image_file = File.Create(filename);

			image.CopyTo(image_file);
			image_file.Close();
		}
	}
}