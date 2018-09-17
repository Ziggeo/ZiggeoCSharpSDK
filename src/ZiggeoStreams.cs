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
        return this.application.connect().getJSONArray("/v1/videos/" + video_token_or_key + "/streams", data);
    }

    public JObject get(string video_token_or_key, string token_or_key) {
        return this.application.connect().getJSON("/v1/videos/" + video_token_or_key + "/streams/" + token_or_key + "", null);
    }

    public Stream download_video(string video_token_or_key, string token_or_key) {
        return this.application.connect().get("/v1/videos/" + video_token_or_key + "/streams/" + token_or_key + "/video", null);
    }

    public Stream download_image(string video_token_or_key, string token_or_key) {
        return this.application.connect().get("/v1/videos/" + video_token_or_key + "/streams/" + token_or_key + "/image", null);
    }

    public JObject push_to_service(string video_token_or_key, string token_or_key, Dictionary<string,string> data) {
        return this.application.connect().postJSON("/v1/videos/" + video_token_or_key + "/streams/" + token_or_key + "/push", data, null);
    }

    public Stream delete(string video_token_or_key, string token_or_key) {
        return this.application.connect().delete("/v1/videos/" + video_token_or_key + "/streams/" + token_or_key + "", null);
    }

    public JObject create(string video_token_or_key, Dictionary<string,string> data, string file) {
        return this.application.connect().postJSON("/v1/videos/" + video_token_or_key + "/streams", data, file);
    }

    public JObject attach_image(string video_token_or_key, string token_or_key, Dictionary<string,string> data, string file) {
        return this.application.connect().postJSON("/v1/videos/" + video_token_or_key + "/streams/" + token_or_key + "/image", data, file);
    }

    public JObject attach_video(string video_token_or_key, string token_or_key, Dictionary<string,string> data, string file) {
        return this.application.connect().postJSON("/v1/videos/" + video_token_or_key + "/streams/" + token_or_key + "/video", data, file);
    }

    public JObject bind(string video_token_or_key, string token_or_key) {
        return this.application.connect().postJSON("/v1/videos/" + video_token_or_key + "/streams/" + token_or_key + "/bind", null, null);
    }

}

