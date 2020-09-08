using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace Video_Upload
{
    public class Video_Upload
    {
        public static void Main(string[] args)
        {

            Ziggeo ziggeo = new Ziggeo(args[0], args[1], "");

            string fileToUpload = args[2];

            Dictionary<string, string> data = new Dictionary<string, string>();
            ziggeo.videos().create(data, fileToUpload);
        }
    }
}
