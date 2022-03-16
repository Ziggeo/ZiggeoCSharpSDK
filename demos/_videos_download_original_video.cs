using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;


namespace Video_Download
{
	public class Video_Download
	{
		public static void Main(string[] args)
		{
			string app_token = args[0];
			string private_key = args[1];
			string video_token = args[2];

			Ziggeo ziggeo = new Ziggeo(app_token, private_key, "");

			dynamic video_to_download = ziggeo.videos().get(video_token);

			string file_extension = video_to_download.original_stream.video_type;

			string file_name = video_to_download.original_stream.token + "." + file_extension;

			var file_content = ziggeo.streams().download_video(video_token, (string) video_to_download.original_stream.token);

			var file_stream = File.Create(file_name);

			file_content.CopyTo(file_stream);

			file_stream.Close();
		}
	}
}