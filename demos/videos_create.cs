using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
/*
	This script will show you how you can create a video by uploading a file

	Parameters you need to pass:
	1. app_token
	2. private_key
	3. file_path
*/
namespace Videos_Create
{
	public class Videos_Create
	{
		public static void Main(string[] args)
		{
			string app_token = args[0];
			string private_key = args[1];
			string file_path = args[2];

			Ziggeo ziggeo = new Ziggeo(app_token, private_key, "");

			Dictionary<string, string> arguments = new Dictionary<string, string>()
			{
				{"file", file_path}
			};

			System.Console.Write(ziggeo.videos().create(arguments, file_path));
		}
	}
}