using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace StreamCreate
{
    public class StreamCreate
    {
        public static void Main(string[] args)
        {

            Ziggeo ziggeo = new Ziggeo(args[0], args[1], "");

            string videoToken = args[2];

            Dictionary<string, string> data = new Dictionary<string, string>();

            string filePath = null;
            if (args.Length > 3) {
                filePath = args[3];
            }

            JObject stream = ziggeo.streams().create(videoToken, data, filePath);

            Console.Write(stream);
        }
    }
}
