using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
/*
	This script will show you how to approve the video through API call through the update call

	Parameters you need to pass:
	1. app_token
	2. private_key
	3. video_token
	4. video_tags
*/
namespace Videos_Update
{
    public class Videos_Update
    {
		public static void Main(string[] args)
		{
			string app_token = args[0];
			string private_key = args[1];
			string video_token = args[2];
			string video_tags = args[3];

			Ziggeo ziggeo = new Ziggeo(app_token, private_key, "");

			Dictionary<string, string> arguments = new Dictionary<string, string>()
			{
				{"tags", video_tags},
			};

			System.Console.Write(ziggeo.videos().update(video_token, arguments));
		}
    }
}