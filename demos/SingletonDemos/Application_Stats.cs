using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace application_stats
{
    public class Application_Stats
    {
        public static void Main(string[] args)
        {

            Ziggeo ziggeo = new Ziggeo(args[0], args[1], "");

            System.Console.WriteLine(ziggeo.application().get_stats(null));
        }

    }

}
    

