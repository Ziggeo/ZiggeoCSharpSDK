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
        return this.application.connect().getJSONArray("/v1/videos/", data);
    }

    public JObject count(Dictionary<string,string> data) {
        return this.application.connect().getJSON("/v1/videos/count", data);
    }

    public JObject get(string token_or_key) {
        return this.application.connect().getJSON("/v1/videos/" + token_or_key + "", null);
    }

    public JArray get_bulk(Dictionary<string,string> data) {
        return this.application.connect().postJSONArray("/v1/videos/get_bulk", data, null);
    }

    public JArray stats_bulk(Dictionary<string,string> data) {
        return this.application.connect().postJSONArray("/v1/videos/stats_bulk", data, null);
    }

    public Stream download_video(string token_or_key) {
        return this.application.cdnConnect().get("/v1/videos/" + token_or_key + "/video", null);
    }

    public Stream download_image(string token_or_key) {
        return this.application.cdnConnect().get("/v1/videos/" + token_or_key + "/image", null);
    }

    public JObject get_stats(string token_or_key) {
        return this.application.connect().getJSON("/v1/videos/" + token_or_key + "/stats", null);
    }

    public JObject push_to_service(string token_or_key, Dictionary<string,string> data) {
        return this.application.connect().postJSON("/v1/videos/" + token_or_key + "/push", data, null);
    }

    public JObject apply_effect(string token_or_key, Dictionary<string,string> data) {
        return this.application.connect().postJSON("/v1/videos/" + token_or_key + "/effect", data, null);
    }

    public JObject apply_meta(string token_or_key, Dictionary<string,string> data) {
        return this.application.connect().postJSON("/v1/videos/" + token_or_key + "/metaprofile", data, null);
    }

    public JObject update(string token_or_key, Dictionary<string,string> data) {
        return this.application.connect().postJSON("/v1/videos/" + token_or_key + "", data, null);
    }

    public JArray update_bulk(Dictionary<string,string> data) {
        return this.application.connect().postJSONArray("/v1/videos/update_bulk", data, null);
    }

    public Stream delete(string token_or_key) {
        return this.application.connect().delete("/v1/videos/" + token_or_key + "", null);
    }

    public JObject create(Dictionary<string,string> data, string file) {
        if (file != null) {
            var result = this.application.connect().postUploadJSON("/v1/videos-upload-url/", "video", data, file, "video_type");
            result["default_stream"] = this.application.connect().postJSON("/v1/videos/" + result["token"] + "/streams/" + result["default_stream"]["token"] + "/confirm-video");
            return result;
        } else {
            return this.application.connect().postJSON("/v1/videos/", data);
        }
    }

    public JArray analytics(string token_or_key, Dictionary<string,string> data) {
        return this.application.connect().postJSONArray("/v1/videos/" + token_or_key + "/analytics", data, null);
    }

}

