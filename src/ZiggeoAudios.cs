using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class ZiggeoAudios {

    private Ziggeo application;

    public ZiggeoAudios(Ziggeo application) {
        this.application = application;
    }

    public JArray index(Dictionary<string,string> data) {
        return this.application.apiConnect().getJSONArray("/server/v1/audios/", data);
    }

    public JObject count(Dictionary<string,string> data) {
        return this.application.apiConnect().getJSON("/server/v1/audios/count", data);
    }

    public JObject get(string token_or_key) {
        return this.application.apiConnect().getJSON("/server/v1/audios/bytoken/" + token_or_key + "", null);
    }

    public JArray get_bulk(Dictionary<string,string> data) {
        return this.application.apiConnect().postJSONArray("/server/v1/audios/get-bulk", data, null);
    }

    public Stream download_audio(string token_or_key) {
        return this.application.connect().get("/v1/server/v1/audios/bytoken/" + token_or_key + "/video", null);
    }

    public JObject update(string token_or_key, Dictionary<string,string> data) {
        return this.application.apiConnect().postJSON("/server/v1/audios/bytoken/" + token_or_key + "", data, null);
    }

    public JArray update_bulk(Dictionary<string,string> data) {
        return this.application.apiConnect().postJSONArray("/server/v1/audios/update-bulk", data, null);
    }

    public Stream delete(string token_or_key) {
        return this.application.apiConnect().delete("/server/v1/audios/bytoken/" + token_or_key + "", null);
    }

    public JObject create(Dictionary<string,string> data, string file) {
    if (file != null) {
        var result = this.application.connect().postUploadJSON("/server/v1/audios/audios-upload-url", "audio", data, file, "audio_type");
        result["default_stream"] = this.application.connect().postJSON("/server/v1/audios/" + result["token"] + "/streams/" + result["default_stream"]["token"] + "/confirm-audio");
        return result;
    } else
            return this.application.apiConnect().postJSON("/server/v1/audios/", data, file);
    }

}

