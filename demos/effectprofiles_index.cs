using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
/*
	This script will show you how to get the list of all effect profiles you have created under your application

	Parameters you need to pass:
	1. app_token
	2. private_key
*/
namespace List_effect_profiles
{
	public class List_profile_profiles
	{
		public static void Main(string[] args)
		{
			string app_token = args[0];
			string private_key = args[1];

			Ziggeo ziggeo = new Ziggeo(app_token, private_key, "");

			Dictionary<string, string> arguments = new Dictionary<string, string>(){};

			dynamic all_effect_profiles = ziggeo.effectProfiles().index(arguments);

			var i = 1;

			foreach (var effect_profile in all_effect_profiles)
			{
				System.Console.WriteLine( i + ". " + effect_profile.token);
				i++;
			}
		}
	}
}