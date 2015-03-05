using System;
using System.Net;
using System.IO;
using System.Text;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class ZiggeoConnect {

	private Ziggeo application;

	public ZiggeoConnect(Ziggeo application) {
		this.application = application;
	}
	
	public Stream request(string method, string path, Dictionary<string,string> data, string file)  {
		string postData = "";
		foreach (string key in data.Keys)
			postData += key + "=" + data[key] + "&";
		string uri = this.application.config().server_api_url + "/v1" + path;
		if (method != "POST")
			uri += "?" + postData;
		HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(uri);
		string authInfo = this.application.token + ":" + this.application.private_key;
		authInfo = Convert.ToBase64String(Encoding.Default.GetBytes(authInfo));
		request.Headers["Authorization"] = "Basic " + authInfo;
		request.Method = method;
		if (method == "POST") {
			byte[] dataEnc = Encoding.ASCII.GetBytes(postData);

			request.ContentType = "application/x-www-form-urlencoded";
			request.ContentLength = dataEnc.Length;

			Stream requestStream = request.GetRequestStream();
			requestStream.Write(dataEnc, 0, dataEnc.Length);
			requestStream.Close();
		} 
		HttpWebResponse response = (HttpWebResponse)request.GetResponse();
		return response.GetResponseStream();
	}
	
	public string requestString(string method, string path, Dictionary<string,string> data, string file)  {
		Stream stream = this.request(method, path, data, file);
		StreamReader reader = new StreamReader(stream);
		string result = reader.ReadToEnd();
		reader.Close();
		stream.Close();
		return result;
	}

	public JObject requestJSON(string method, string path, Dictionary<string,string> data, string file) {
		return JObject.Parse(this.requestString(method, path, data, file));
	}

	public JArray requestJSONArray(string method, string path, Dictionary<string,string> data, string file) {
		return JArray.Parse(this.requestString(method, path, data, file));
	}

	public Stream get(string path, Dictionary<string,string> data) {
		return this.request("GET", path, data, null);
	}

	public JObject getJSON(string path, Dictionary<string,string> data) {
		return this.requestJSON("GET", path, data, null);
	}

	public JArray getJSONArray(string path, Dictionary<string,string> data) {
		return this.requestJSONArray("GET", path, data, null);
	}

	public Stream post(string path, Dictionary<string,string> data, string file) {
		return this.request("POST", path, data, file);
	}

	public JObject postJSON(string path, Dictionary<string,string> data, string file) {
		return this.requestJSON("POST", path, data, file);
	}

	public Stream delete(string path, Dictionary<string,string> data) {
		return this.request("DELETE", path, data, null);
	}

	public JObject deleteJSON(string path, Dictionary<string,string> data) {
		return this.requestJSON("DELETE", path, data, null);
	}

}