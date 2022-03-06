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
			string app_token = args[0];
			string private_key = args[1];

			Ziggeo ziggeo = new Ziggeo(app_token, private_key, "");

			Dictionary<string, string> arguments = new Dictionary<string, string>(){};

			dynamic all_videos = ziggeo.videos().index(arguments);

			if(all_videos != null)
			{
				foreach (var item in all_videos)
				{
					string video_token = item.token;

					string file_name = "video_" + video_token + ".mp4";

					System.Console.WriteLine("downloading: " + video_token + " as " + file_name);

					var file_content = ziggeo.videos().download_video(video_token);

					var file_stream = File.Create(file_name);

					file_content.CopyTo(file_stream);

					file_stream.Close();
				}
			}
		}
	}
}