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
*/
namespace Videos_Count
{
	public class Videos_Count
	{
		public static void Main(string[] args)
		{
			string app_token = args[0];
			string private_key = args[1];

			Ziggeo ziggeo = new Ziggeo(app_token, private_key, "");

			System.Console.Write(ziggeo.videos().count(null)["count"]);
		}
	}
}