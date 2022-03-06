using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
/*
	This script will show you how you can get the list of videos from your account

	Parameters you need to pass:
	1. app_token
	2. private_key
*/
namespace Videos_Index
{
	public class Videos_Index
	{
		public static void Main(string[] args)
		{
			string app_token = args[0];
			string private_key = args[1];

			Ziggeo ziggeo = new Ziggeo(app_token, private_key, "");

			Dictionary<string, string> arguments = new Dictionary<string, string>(){};

			dynamic all_videos = ziggeo.videos().index(arguments);

			var i = 0;

			foreach (var video in all_videos)
			{
				System.Console.WriteLine(i + ". " + video.token + "(" + video.key + ")");
			}
		}
	}
}