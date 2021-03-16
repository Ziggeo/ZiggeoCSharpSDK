using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class ZiggeoMetaProfileProcess {

    private Ziggeo application;

    public ZiggeoMetaProfileProcess(Ziggeo application) {
        this.application = application;
    }

    public JArray index(string meta_token_or_key) {
        return this.application.connect().getJSONArray("/v1/metaprofiles/" + meta_token_or_key + "/process", null);
    }

    public JObject get(string meta_token_or_key, string token_or_key) {
        return this.application.connect().getJSON("/v1/metaprofiles/" + meta_token_or_key + "/process/" + token_or_key + "", null);
    }

    public Stream delete(string meta_token_or_key, string token_or_key) {
        return this.application.connect().delete("/v1/metaprofiles/" + meta_token_or_key + "/process/" + token_or_key + "", null);
    }

    public JObject create_video_analysis_process(string meta_token_or_key) {
        return this.application.connect().postJSON("/v1/metaprofiles/" + meta_token_or_key + "/process/analysis", null, null);
    }

    public JObject create_audio_transcription_process(string meta_token_or_key) {
        return this.application.connect().postJSON("/v1/metaprofiles/" + meta_token_or_key + "/process/transcription", null, null);
    }

    public JObject create_nsfw_process(string meta_token_or_key, Dictionary<string,string> data) {
        return this.application.connect().postJSON("/v1/metaprofiles/" + meta_token_or_key + "/process/nsfw", data, null);
    }

    public JObject create_profanity_process(string meta_token_or_key, Dictionary<string,string> data) {
        return this.application.connect().postJSON("/v1/metaprofiles/" + meta_token_or_key + "/process/profanity", data, null);
    }

}

