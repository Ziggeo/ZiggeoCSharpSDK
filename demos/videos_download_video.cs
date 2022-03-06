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
namespace Videos_Download_Video
{
	public class Videos_Download_Video
	{
		public static void Main(string[] args)
		{
			string app_token = args[0];
			string private_key = args[1];
			string video_token = args[2];
			string filename = args[3];

			Ziggeo ziggeo = new Ziggeo(app_token, private_key, "");

			var video = ziggeo.videos().download_video(video_token);

			var video_file = File.Create(filename);

			video.CopyTo(video_file);
			video_file.Close();
		}
	}
}