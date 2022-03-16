using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace Filter_by_tags
{
	public class Filter_by_tags
	{
		public static void Main(string[] args)
		{
			string app_token = args[0];
			string private_key = args[1];

			Ziggeo ziggeo = new Ziggeo(app_token, private_key, "");

			Dictionary<string, string> arguments = new Dictionary<string, string>()
			{
				{"tags","tag1, tag2"},
			};
			///to add more than one tag, input all tags encoded as a comma-separated string

			dynamic all_videos = ziggeo.videos().index(arguments);

			foreach (var item in all_videos)
			{
				System.Console.WriteLine("Listing" + item.token + "/" + item.key);
			}
		}
	}
}