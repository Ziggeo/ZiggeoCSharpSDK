using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
/*
	This script will allow you to get the stats of your application

	Parameters you need to pass:
	1. app_token
	2. private_key
*/
namespace Application_Get_Stats
{
	public class Application_Get_Stats
	{
		public static void Main(string[] args)
		{
			string app_token = args[0];
			string private_key = args[1];

			Ziggeo ziggeo = new Ziggeo(app_token, private_key, "");

			System.Console.WriteLine(ziggeo.application().get_stats(null));
		}
	}
}