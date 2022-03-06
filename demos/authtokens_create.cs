using System;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
/*
	This script will show you how to create server side auth tokens

	docs: https://ziggeo.com/docs/api/authorization-tokens/

	Parameters you need to pass:
	1. app_token
	2. private_key
*/
class Authtokens_Create
{
	public static void Main(string[] args)
	{
		string app_token = args[0];
		string private_key = args[1];

		Ziggeo ziggeo = new Ziggeo(app_token, private_key, "");

		Dictionary<string, string> auth_details = new Dictionary<string, string>()
		{
			{"session_limit","1"},
			{"usage_expiration_time","6000" },
			{"grants", "{\"read\":{\"all\": true}}"}
		};

		System.Console.Write(string.Join(" ", auth_details));

		System.Console.WriteLine(ziggeo.authtokens().create(auth_details));
	}
}