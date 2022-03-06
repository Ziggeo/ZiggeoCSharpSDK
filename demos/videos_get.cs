using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
/*
	This script will show you how you can get the number of all videos in your application

	Parameters you need to pass:
	1. app_token
	2. private_key
	3. video_token
*/
namespace Videos_Get
{
	public class Videos_Get
	{
		public static void Main(string[] args)
		{
			string app_token = args[0];
			string private_key = args[1];
			string video_token = args[2];

			Ziggeo ziggeo = new Ziggeo(app_token, private_key, "");

			System.Console.Write(ziggeo.videos().get(video_token));
		}
	}
}