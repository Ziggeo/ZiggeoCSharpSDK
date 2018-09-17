using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace video_count
{
    public class Video_Count
    {
        public static void Main(string[] args)
        {

            Ziggeo ziggeo = new Ziggeo(args[0], args[1], "");

            System.Console.WriteLine(ziggeo.videos().count(null)["count"]);
        }

    }

}
    

