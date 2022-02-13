using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class ZiggeoAudio_streams {

    private Ziggeo application;

    public ZiggeoAudio_streams(Ziggeo application) {
        this.application = application;
    }

    public JArray index(string audio_token_or_key, Dictionary<string,string> data) {
        return this.application.apiConnect().getJSONArray("/server/v1/audios/bytoken/" + audio_token_or_key + "/streams", data);
    }

    public JObject get(string audio_token_or_key, string token_or_key) {
        return this.application.apiConnect().getJSON("/server/v1/audios/bytoken/" + audio_token_or_key + "/streams/bytoken/" + token_or_key + "", null);
    }

    public Stream download_audio(string audio_token_or_key, string token_or_key) {
        return this.application.connect().get("/v1/server/v1/audios/bytoken/" + audio_token_or_key + "/streams/bytoken/" + token_or_key + "/audio", null);
    }

    public Stream delete(string audio_token_or_key, string token_or_key) {
        return this.application.apiConnect().delete("/server/v1/audios/bytoken/" + audio_token_or_key + "/streams/bytoken/" + token_or_key + "", null);
    }

    public JObject create(string audio_token_or_key, Dictionary<string,string> data, string file) {
    if (file != null) {
        var result = this.application.connect().postUploadJSON("/server/v1/audios/" + audio_token_or_key + "/streams-upload-url", "stream", data, file, "audio_type");
        result = this.application.connect().postJSON("/server/v1/audios/" + audio_token_or_key + "/streams/" + result["token"] + "/confirm-video");
        return result;
    } else
            return this.application.apiConnect().postJSON("/server/v1/audios/bytoken/" + audio_token_or_key + "/streams", data, file);
    }

}

