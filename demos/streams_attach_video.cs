using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
/*
	This script will show you how you can create the video stream, utilizing the streams methods.

	Parameters you need to pass:
	1. app_token - app token
	2. private_key - private key
	3. video_token - video to which the stream belongs to
	4. stream_token - the stream to be updated
	5. file_path - path to video file

*/
namespace Streams_Attach_Video
{
	public class Streams_Attach_Video
	{
		public static void Main(string[] args)
		{
			string app_token = args[0];
			string private_key = args[1];
			string video_token = args[2];
			string stream_token = args[3];
			string file_path = args[4];

			Ziggeo ziggeo = new Ziggeo(app_token, private_key, "");

			Dictionary<string, string> arguments = new Dictionary<string, string>()
			{
				{"file", file_path}
			};

			Console.Write(ziggeo.streams().attach_video(video_token, stream_token, arguments, file_path));
		}
	}
}