using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
namespace Set_tags
{
    public class Set_tags
    {
		public static void Main(string[] args)
		{
			Ziggeo ziggeo = new Ziggeo("APP_TOKEN", "PRIVATE_KEY", "ENCRYPTION_KEY");

			Dictionary<string, string> dict = new Dictionary<string, string>()
				{
					{"tags","Your video TAGS"},
				};

			ziggeo.videos().update("Video_TOKEN", dict);
			System.Console.WriteLine("Video has now been updated!!");

		}
    }
}
