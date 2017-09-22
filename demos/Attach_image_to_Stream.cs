using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace Attach_image
{
    public class Attach_Image
    {
        public static void Main(string[] args)
        {

            Ziggeo ziggeo = new Ziggeo("APP_TOKEN", "PRIVATE_KEY", "ENCRYPTION_KEY");

            dynamic StreamToGet = JsonConvert.DeserializeObject(ziggeo.streams().get("Video_TOKEN", "stream_Token"));

            string ImageToAttach = "Your Image File";

            ziggeo.streams().attach_image(StreamToGet, ImageToAttach);

        }
    }
}