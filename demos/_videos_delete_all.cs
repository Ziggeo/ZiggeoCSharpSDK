using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace Delete_all_videos
{
	public class Delete_All_Videos
	{
		public static void Main(string[] args)
		{
			string app_token = args[0];
			string private_key = args[1];

			Ziggeo ziggeo = new Ziggeo(app_token, private_key, "");

			while (true)
			{
				Dictionary<string, string> arguments = new Dictionary<string, string>(){};

				dynamic all_videos = ziggeo.videos().index(arguments);

				if (all_videos.Count == 0)
					break;

				foreach (var item in all_videos)
				{
					System.Console.WriteLine("Deleting: " + item.token);
					ziggeo.videos().delete((string) item.token);
				}
			}
		}
	}
}