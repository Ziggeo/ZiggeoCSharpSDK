using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace Set_Min_Duration
{
    public class Set_Min_Duration
    {
		public static void Main(string[] args)
		{
			Ziggeo ziggeo = new Ziggeo("APP_TOKEN", "PRIVATE_KEY", "ENCRYPTION_KEY");

			Dictionary<string, string> dict = new Dictionary<string, string>()
				{
					{"min_duration","1"},
				};

			///min_duration is the Minimal duration of video

			ziggeo.videos().update("Video_TOKEN", dict);
			System.Console.WriteLine("Video has now been approved!!");

		}
    }
}
