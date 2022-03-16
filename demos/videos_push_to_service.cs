using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
/*
	This script will show you how you can push a video to some auto push service you have previously configured.

	You'll need to:
	1. Create new integration in the dashboard
	2. Then create push service using the integration on your application's dashboard
	3. Grab the push service token and use it here.

	Parameters you need to pass:
	1. app_token
	2. private_key
	3. video_token
	4. push_service_token
*/
namespace Videos_Push_To_Service
{
	public class Videos_Push_To_Service
	{
		public static void Main(string[] args)
		{
			string app_token = args[0];
			string private_key = args[1];
			string video_token = args[2];
			string push_service_token = args[3];

			Ziggeo ziggeo = new Ziggeo(app_token, private_key, "");

			Dictionary<string, string> arguments = new Dictionary<string, string>()
			{
				{"pushservicetoken", push_service_token},
			};

			System.Console.Write(ziggeo.videos().push_to_service(video_token, arguments));
		}
	}
}