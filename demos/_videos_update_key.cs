using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace Set_Key
{
	public class Set_Key
	{
		public static void Main(string[] args)
		{
			string app_token = args[0];
			string private_key = args[1];
			string video_token = args[2];

			Ziggeo ziggeo = new Ziggeo(app_token, private_key, "");

			Dictionary<string, string> arguments = new Dictionary<string, string>()
			{
				{"key","unique_name"},
			};

			/// key is the Unique (optional) name of the video

			ziggeo.videos().update(video_token, arguments);
			System.Console.WriteLine("Video has now been approved!!");
		}
	}
}