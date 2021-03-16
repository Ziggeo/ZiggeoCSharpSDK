using System;
using System.Net;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Diagnostics;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class ZiggeoConnect {

	private Ziggeo application;
	private string baseUri;
	private ZiggeoConfig config;

    public ZiggeoConnect(Ziggeo application, string baseUri) {
		this.application = application;
		this.baseUri = baseUri;
        this.config = new ZiggeoConfig();
	}

	public ZiggeoConnect(Ziggeo application, string baseUri, ZiggeoConfig config) {
		this.application = application;
		this.baseUri = baseUri;
		this.config = config;
	}

	public Stream makeRequest(string method, string path, Dictionary<string, string> data, string file) {
        int statusCode = 0;
		for(int i = 0; i < this.config.resilience_factor; i++) {
			HttpWebResponse res = this.request(method, path, data, file);
            if((int)res.StatusCode >= 200 && (int)res.StatusCode < 500) {
                //good to go
                return res.GetResponseStream();
            }
            statusCode = (int)res.StatusCode;
		}
        
        Dictionary<string, string> errRes = new Dictionary<string, string>();

        //If failed return the default value
        errRes["response"] = (string) this.config.resilience_onfail["error"];

        if(statusCode == 0) {
            errRes["StatusCode"] = "900"; //Just a unique code to recognize that the error is internal in nature. At this point you could grab more details from $result['error']
        }
        string errorResponse = JsonConvert.SerializeObject(errRes, Formatting.Indented);
        var errorResponseStream = new MemoryStream();
        this.WriteStringToStream(errorResponseStream, errorResponse);
        return errorResponseStream;
	}

    public Stream makeUploadRequest(string path, Dictionary<string, string> data, string file) {
        int statusCode = 0;
		for(int i = 0; i < this.config.resilience_factor; i++) {
			HttpWebResponse res = this.uploadFileRequest(path, data, file);
            if((int)res.StatusCode >= 200 && (int)res.StatusCode < 500) {
                //good to go
                return res.GetResponseStream();
            }
            statusCode = (int)res.StatusCode;
		}
        
        throw new InvalidOperationException("Too many upload attempts failed");
	}

    public HttpWebResponse request(string method, string path, Dictionary<string, string> data, string file)
    {
        string postData = "";
        if (data != null) {
            foreach (string key in data.Keys)
                postData += key + "=" + data[key] + "&";
        }

        string uri = this.baseUri +  path;
        if (method != "POST")
            uri += "?" + postData;
        HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(uri);
        string authInfo = this.application.token + ":" + this.application.private_key;
        authInfo = Convert.ToBase64String(Encoding.Default.GetBytes(authInfo));
        request.Headers["Authorization"] = "Basic " + authInfo;
        request.Method = method;
        if (method == "POST")
        {
            byte[] dataEnc = Encoding.ASCII.GetBytes(postData);


            if (!string.IsNullOrEmpty(file))
            {
                string boundary = "----------" + DateTime.Now.Ticks.ToString("x");
                request.ContentType = "multipart/form-data; boundary=" + boundary;
                Stream requestStream = request.GetRequestStream();
                WriteMultipartForm(requestStream, boundary, data, file, "video/mp4");
                requestStream.Close();
            }
            else
            {
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = dataEnc.Length;
                Stream requestStream = request.GetRequestStream();
                requestStream.Write(dataEnc, 0, dataEnc.Length);
                requestStream.Close();
            }
        }
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        return response;
    }

    public HttpWebResponse uploadFileRequest(string path, Dictionary<string, string> data, string file)
    {
        Trace.Write(path);
        string postData = "";
        if (data != null) {
            foreach (string key in data.Keys)
                postData += key + "=" + data[key] + "&";
        }
        string uri = path;
        HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(uri);
        request.Method = "POST";
        string boundary = "----------" + DateTime.Now.Ticks.ToString("x");
        request.ContentType = "multipart/form-data; boundary=" + boundary;
        Stream requestStream = request.GetRequestStream();
        WriteMultipartForm(requestStream, boundary, data, file, "video/mp4");
        requestStream.Close();
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        return response;
    }

    private void WriteMultipartForm(Stream s, string boundary, Dictionary<string, string> data, string fileName, string fileContentType)
    {
        byte[] boundarybytes = Encoding.UTF8.GetBytes("--" + boundary + "\r\n");
        byte[] trailer = Encoding.UTF8.GetBytes("\r\n--" + boundary + "--\r\n");

        if (data != null)
        {
            foreach (string key in data.Keys)
            {
                WriteDataToStream(s, boundarybytes);
                WriteStringToStream(s,
                    string.Format("Content-Disposition: form-data; name=\"{0}\"\r\n\r\n{1}\r\n",
                                    key,
                                    data[key])
                );
            }
        }

        WriteDataToStream(s, boundarybytes);
        WriteStringToStream(s,
            string.Format("Content-Disposition: form-data; name=\"{0}\"; filename=\"{1}\";\r\nContent-Type: {2}\r\n\r\n",
                            "file",
                            System.IO.Path.GetFileName(fileName),
                            fileContentType)
        );
        using (FileStream inputFile = File.OpenRead(fileName))
        {
            inputFile.CopyTo(s);
        }
        WriteDataToStream(s, trailer);
    }

    private void WriteStringToStream(Stream s, string str)
    {
        byte[] bytes = Encoding.UTF8.GetBytes(str);
        s.Write(bytes, 0, bytes.Length);
    }

    private void WriteDataToStream(Stream s, byte[] bytes)
    {
        s.Write(bytes, 0, bytes.Length);
    }
	
	public string requestString(string method, string path, Dictionary<string,string> data, string file)  {
		Stream stream = this.makeRequest(method, path, data, file);
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
		return this.makeRequest("GET", path, data, null);
	}

	public JObject getJSON(string path, Dictionary<string,string> data) {
		return this.requestJSON("GET", path, data, null);
	}

	public JArray getJSONArray(string path, Dictionary<string,string> data) {
		return this.requestJSONArray("GET", path, data, null);
	}

	public Stream post(string path, Dictionary<string,string> data, string file) {
		return this.makeRequest("POST", path, data, file);
	}

    public JObject postUploadJSON(string path, string scope, Dictionary<string,string> data, string file, string type_key) {
        if (type_key != null) {
            data[type_key] = Path.GetExtension(file);
        }
		var resp = this.postJSON(path, data);
        var ret = resp[scope];
		Dictionary<string, string> urlData = resp["url_data"]["fields"].ToObject<Dictionary<string, string>>();
		this.makeUploadRequest((string) resp["url_data"]["url"], urlData, file);
		return (JObject) ret;
	}

    public JObject postJSON(string path, Dictionary<string,string> data, string file) {
		return this.requestJSON("POST", path, data, file);
	}

	public JObject postJSON(string path, Dictionary<string,string> data) {
		return this.requestJSON("POST", path, data, null);
	}

    public JObject postJSON(string path) {
		return this.requestJSON("POST", path, null, null);
	}

    public JArray postJSONArray(string path, Dictionary<string,string> data, string file) {
		return this.requestJSONArray("POST", path, data, file);
	}

	public Stream delete(string path, Dictionary<string,string> data) {
		return this.makeRequest("DELETE", path, data, null);
	}

	public JObject deleteJSON(string path, Dictionary<string,string> data) {
		return this.requestJSON("DELETE", path, data, null);
	}

}
