using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace Set_Max_Duration
{
    public class Set_Max_Duration
    {
		public static void Main(string[] args)
		{
			Ziggeo ziggeo = new Ziggeo("APP_TOKEN", "PRIVATE_KEY", "ENCRYPTION_KEY");

			Dictionary<string, string> dict = new Dictionary<string, string>()
				{
					{"max_duration","10"},
				};

			///max_duration is the Maximum duration of video

			ziggeo.videos().update("Video_TOKEN", dict);
			System.Console.WriteLine("Video has now been approved!!");

		}
    }
}
