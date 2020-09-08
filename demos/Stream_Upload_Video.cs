using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace Stream_Upload_Video
{
    public class Stream_Upload_Video
    {
        public static void Main(string[] args)
        {

            Ziggeo ziggeo = new Ziggeo(args[0], args[1], "");

            string videoToken = args[2];
            string streamToken = args[3];

            Dictionary<string, string> data = new Dictionary<string, string>();

            string filePath = args[4];

            JObject stream = ziggeo.streams().attach_video(videoToken, streamToken, data, filePath);

            Console.Write(stream);
        }
    }
}
