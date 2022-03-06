using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace expiration_days
{
	public class Expiration_Days
	{
		public static void Main(string[] args)
		{
			string app_token = args[0];
			string private_key = args[1];
			string video_token = args[2];

			Ziggeo ziggeo = new Ziggeo(app_token, private_key, "");

			Dictionary<string, string> arguments = new Dictionary<string, string>()
			{
				{"expiration_days","NUMBER_OF_EXPIRARION_DAYS"},
			};

			ziggeo.videos().update(video_token, arguments);

			System.Console.WriteLine("Your video has been updated!!");
		}
	}
}