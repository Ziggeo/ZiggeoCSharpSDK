using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class ZiggeoVideos {

    private Ziggeo application;

    public ZiggeoVideos(Ziggeo application) {
        this.application = application;
    }

    public JArray index(Dictionary<string,string> data) {
        return this.application.connect().getJSONArray("/videos/", data);
    }

    public JObject count(Dictionary<string,string> data) {
        return this.application.connect().getJSON("/videos/count", data);
    }

    public JObject get(string token_or_key) {
        return this.application.connect().getJSON("/videos/" + token_or_key + "", null);
    }

    public JArray get_bulk(Dictionary<string,string> data) {
        return this.application.connect().postJSONArray("/videos/get_bulk", data, null);
    }

    public Stream download_video(string token_or_key) {
        return this.application.connect().get("/videos/" + token_or_key + "/video", null);
    }

    public Stream download_image(string token_or_key) {
        return this.application.connect().get("/videos/" + token_or_key + "/image", null);
    }

    public JObject push_to_service(string token_or_key, Dictionary<string,string> data) {
        return this.application.connect().postJSON("/videos/" + token_or_key + "/push", data, null);
    }

    public JObject apply_effect(string token_or_key, Dictionary<string,string> data) {
        return this.application.connect().postJSON("/videos/" + token_or_key + "/effect", data, null);
    }

    public JObject update(string token_or_key, Dictionary<string,string> data) {
        return this.application.connect().postJSON("/videos/" + token_or_key + "", data, null);
    }

    public JArray update_bulk(Dictionary<string,string> data) {
        return this.application.connect().postJSONArray("/videos/update_bulk", data, null);
    }

    public Stream delete(string token_or_key) {
        return this.application.connect().delete("/videos/" + token_or_key + "", null);
    }

    public JObject create(Dictionary<string,string> data, string file) {
        return this.application.connect().postJSON("/videos/", data, file);
    }

    public JArray analytics(string token_or_key, Dictionary<string,string> data) {
        return this.application.connect().postJSONArray("/videos/" + token_or_key + "/analytics", data, null);
    }

}

