using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
/*
	This script will show you how to get details of a stream of specific video

	Parameters you need to pass:
	1. app_token
	2. private_key
	3. video_token
	4. file_path
*/
namespace Streams_Create
{
	public class Streams_Create
	{
		public static void Main(string[] args)
		{
			string app_token = args[0];
			string private_key = args[1];
			string video_token = args[2];
			string file_path = args[3];

			Ziggeo ziggeo = new Ziggeo(app_token, private_key, "");

			Dictionary<string, string> arguments = new Dictionary<string, string>()
			{
				{"file", file_path},
			};

			System.Console.Write(ziggeo.streams().create(video_token, arguments, file_path));
		}
	}
}