using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace Set_volatile
{
    public class Set_volatile
    {
		public static void Main(string[] args)
		{
			Ziggeo ziggeo = new Ziggeo("APP_TOKEN", "PRIVATE_KEY", "ENCRYPTION_KEY");

			Dictionary<string, string> dict = new Dictionary<string, string>()
				{
					{"volatile","true"},
				};

			///Volatile Automatically removes the video if it remains empty

			ziggeo.videos().update("Video_TOKEN", dict);
			System.Console.WriteLine("Video has now been updated!!");

		}
    }
}
