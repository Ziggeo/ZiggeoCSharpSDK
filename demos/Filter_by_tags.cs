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
		public static void main(string[] args)
		{
			Ziggeo ziggeo = new Ziggeo("APP_TOKEN", "PRIVATE_KEY", "ENCRYPTION_KEY");

			Dictionary<string, string> dict = new Dictionary<string, string>()
				{
					{"tags","tag1, tag2"},
				};

			///to add more than one tag, input all tags encoded as a comma-separated string

			dynamic AllVideos = JsonConvert.DeserializeObject(ziggeo.videos().index(dict));

			foreach (var item in AllVideos)
			{

				System.Console.WriteLine("Listing" + item.token + "/" + item.key);

			}
		}
    }
}
