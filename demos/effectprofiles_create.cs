using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
/*
	This script will show you how to create an effect profile through API

	Parameters you need to pass:
	1. app_token
	2. private_key
	3. effect_title
	4. effect_key
*/
namespace EffectProfiles_Create
{
	public class EffectProfiles_Create
	{
		public static void Main(string[] args)
		{
			string app_token = args[0];
			string private_key = args[1];
			string effect_title = args[2];
			string effect_key = args[3];

			Ziggeo ziggeo = new Ziggeo(app_token, private_key, "");

			Dictionary<string, string> profile = new Dictionary<string, string>()
			{
				{"key", effect_key},
				{"title", effect_title},
			};

			System.Console.WriteLine(ziggeo.effectProfiles().create(profile));
		}
	}

}