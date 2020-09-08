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
        return this.application.cdnConnect().get("/v1/videos/" + video_token_or_key + "/streams/" + token_or_key + "/video", null);
    }

    public Stream download_image(string video_token_or_key, string token_or_key) {
        return this.application.cdnConnect().get("/v1/videos/" + video_token_or_key + "/streams/" + token_or_key + "/image", null);
    }

    public JObject push_to_service(string video_token_or_key, string token_or_key, Dictionary<string,string> data) {
        return this.application.connect().postJSON("/v1/videos/" + video_token_or_key + "/streams/" + token_or_key + "/push", data, null);
    }

    public Stream delete(string video_token_or_key, string token_or_key) {
        return this.application.connect().delete("/v1/videos/" + video_token_or_key + "/streams/" + token_or_key + "", null);
    }

    public JObject create(string video_token_or_key, Dictionary<string,string> data, string file) {
        if (file != null) {
            var result = this.application.connect().postUploadJSON("/v1/videos/" + video_token_or_key + "/streams-upload-url/", "stream", data, file, "video_type");
            var streamResult = this.application.connect().postJSON("/v1/videos/" + video_token_or_key + "/streams/" + result["token"] + "/confirm-video");
            return streamResult;
        } else {
            return this.application.connect().postJSON("/v1/videos/" + video_token_or_key + "/streams/", data);
        }
    }

    public JObject attach_image(string video_token_or_key, string token_or_key, Dictionary<string,string> data, string file) {
        if (file != null) {
            var result = this.application.connect().postUploadJSON("/v1/videos/" + video_token_or_key + "/streams/" + token_or_key + "/image-upload-url", "stream", data, file, null);
            var streamResult = this.application.connect().postJSON("/v1/videos/" + video_token_or_key + "/streams/" + result["token"] + "/confirm-image");
            return streamResult;
        } else {
            return this.application.connect().postJSON("/v1/videos/" + video_token_or_key + "/streams/" + token_or_key + "/image", data);
        }
    }

    public JObject attach_video(string video_token_or_key, string token_or_key, Dictionary<string,string> data, string file) {
        if (file != null) {
            var result = this.application.connect().postUploadJSON("/v1/videos/" + video_token_or_key + "/streams/" + token_or_key + "/video-upload-url", "stream", data, file, "video_type");
            var streamResult = this.application.connect().postJSON("/v1/videos/" + video_token_or_key + "/streams/" + result["token"] + "/confirm-video");
            return streamResult;
        } else {
            return this.application.connect().postJSON("/v1/videos/" + video_token_or_key + "/streams/" + token_or_key + "/video", data);
        }
    }

    public JObject attach_subtitle(string video_token_or_key, string token_or_key, Dictionary<string,string> data) {
        return this.application.connect().postJSON("/v1/videos/" + video_token_or_key + "/streams/" + token_or_key + "/subtitle", data, null);
    }

    public JObject bind(string video_token_or_key, string token_or_key) {
        return this.application.connect().postJSON("/v1/videos/" + video_token_or_key + "/streams/" + token_or_key + "/bind", null, null);
    }

}

