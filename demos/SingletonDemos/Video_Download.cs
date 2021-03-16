using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;


namespace Video_Download
{
    public class Video_Download
    {
			public static void Main(string[] args)
			{

				Ziggeo ziggeo = new Ziggeo(args[0], args[1], "");

				dynamic videoToDownload = ziggeo.videos().get(args[2]);

				string fileExtension = videoToDownload.original_stream.video_type;

				string fileName = videoToDownload.original_stream.video_token + "." + fileExtension;

				var fileContent = ziggeo.videos().download_video((string) videoToDownload.token);

				string filePath = "/home/pabloi/" + fileName;
				
				var fileStream = File.Create(filePath);
				
				fileContent.CopyTo(fileStream);
				
				fileStream.Close();
			}

    }
}




