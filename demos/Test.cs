using System;
using System.Net;
using System.IO;
using System.Text;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
 
public class HelloWorld
{
	
    static public void Main () {
    	Ziggeo c = new Ziggeo("r1d9bf219e0598cf97cff19168517027", "r1c3c6599b3eeb32d9a8405808caa98d", "a2d88bbe14d5b64221913dc7109f93ba");
    	Dictionary<string, string> dict = new Dictionary<string, string>();
    	//dict["data"]="{\"peeps\":4567}";
    	//c.videos().delete("f76bf95d2568d693caa245ed388ab9a6");
    	Console.WriteLine(c.videos().index(dict));
    }
}