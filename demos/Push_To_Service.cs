using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace Push_Service
{
    public class Push_To_Service
    {
		public static void Main(string[] args)
		{
			Ziggeo ziggeo = new Ziggeo("APP_TOKEN", "PRIVATE_KEY", "ENCRYPTION_KEY");

			Dictionary<string, string> push = new Dictionary<string, string>()
				{
					{"pushservicetoken","YOUR Push Services's token"},
				};

			ziggeo.videos().push_to_service("Video_TOKEN", push);
			System.Console.WriteLine("Video has now been pushed!!");

		}
    }
}
