using System;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

class HelloWorld
{
    static JObject CreateZiggeoToken() {
        Ziggeo ziggeo = new Ziggeo("APP_TOKEN", "PRIVATE_KEY", "ENCRYPTION_KEY");

        Dictionary<string, string> dict = new Dictionary<string, string>()
        {
            {"session_limit","1"},
            {"usage_expiration_time","100" },
            {"grants", "{\"read\":{\"all\": true}}"}
        };

        Console.Write(string.Join(" ", dict));

        return ziggeo.authtokens().create(dict);

    }
    static void Main(string[] args)
      {
         Console.WriteLine("Hello World");
         JObject a = CreateZiggeoToken();
         Console.WriteLine( a );
         Console.ReadKey();
      }
}