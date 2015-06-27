using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class ZiggeoStreams {

    private Ziggeo application;

    public ZiggeoStreams(Ziggeo application) {
        this.application = application;
    }

    public JArray index(string video_token_or_key, Dictionary<string,string> data) {
        return this.application.connect().getJSONArray("/videos/" + video_token_or_key + "/streams", data);
    }

    public JObject get(string video_token_or_key, string token_or_key) {
        return this.application.connect().getJSON("/videos/" + video_token_or_key + "/streams/" + token_or_key + "", null);
    }

    public Stream download_video(string video_token_or_key, string token_or_key) {
        return this.application.connect().get("/videos/" + video_token_or_key + "/streams/" + token_or_key + "/video", null);
    }

    public Stream download_image(string video_token_or_key, string token_or_key) {
        return this.application.connect().get("/videos/" + video_token_or_key + "/streams/" + token_or_key + "/image", null);
    }

    public Stream delete(string video_token_or_key, string token_or_key) {
        return this.application.connect().delete("/videos/" + video_token_or_key + "/streams/" + token_or_key + "", null);
    }

    public JObject create(string video_token_or_key, Dictionary<string,string> data, string file) {
        return this.application.connect().postJSON("/videos/" + video_token_or_key + "/streams", data, file);
    }

    public JObject attach_image(string video_token_or_key, string token_or_key, Dictionary<string,string> data, string file) {
        return this.application.connect().postJSON("/videos/" + video_token_or_key + "/streams/" + token_or_key + "/image", data, file);
    }

    public JObject attach_video(string video_token_or_key, string token_or_key, Dictionary<string,string> data, string file) {
        return this.application.connect().postJSON("/videos/" + video_token_or_key + "/streams/" + token_or_key + "/video", data, file);
    }

    public JObject bind(string video_token_or_key, string token_or_key) {
        return this.application.connect().postJSON("/videos/" + video_token_or_key + "/streams/" + token_or_key + "/bind", null, null);
    }

}

