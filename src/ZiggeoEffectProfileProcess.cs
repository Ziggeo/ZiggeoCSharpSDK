using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class ZiggeoEffectProfileProcess {

    private Ziggeo application;

    public ZiggeoEffectProfileProcess(Ziggeo application) {
        this.application = application;
    }

    public JArray index(string effect_token_or_key, Dictionary<string,string> data) {
        return this.application.connect().getJSONArray("/v1/effects/" + effect_token_or_key + "/process", data);
    }

    public JObject get(string effect_token_or_key, string token_or_key) {
        return this.application.connect().getJSON("/v1/effects/" + effect_token_or_key + "/process/" + token_or_key + "", null);
    }

    public Stream delete(string effect_token_or_key, string token_or_key) {
        return this.application.connect().delete("/v1/effects/" + effect_token_or_key + "/process/" + token_or_key + "", null);
    }

    public JObject create_filter_process(string effect_token_or_key, Dictionary<string,string> data) {
        return this.application.connect().postJSON("/v1/effects/" + effect_token_or_key + "/process/filter", data, null);
    }

    public JObject create_watermark_process(string effect_token_or_key, Dictionary<string,string> data, string file) {
    if (file != null) {
        var result = this.application.connect().postUploadJSON("/v1/effects/" + effect_token_or_key + "/process/watermark-upload-url", "effect_process", data, file, null);
        result = this.application.connect().postJSON("/v1/effects/" + effect_token_or_key + "/process/" + result["token"] + "/confirm-watermark");
        return result;
    } else
            return this.application.connect().postJSON("/v1/effects/" + effect_token_or_key + "/process/watermark", data, file);
    }

    public JObject edit_watermark_process(string effect_token_or_key, string token_or_key, Dictionary<string,string> data, string file) {
    if (file != null) {
        var result = this.application.connect().postUploadJSON("/v1/effects/" + effect_token_or_key + "/process/" + token_or_key + "/watermark-upload-url", "effect_process", data, file, null);
        result = this.application.connect().postJSON("/v1/effects/" + effect_token_or_key + "/process/" + token_or_key + "/confirm-watermark");
        return result;
    } else
            return this.application.connect().postJSON("/v1/effects/" + effect_token_or_key + "/process/watermark/" + token_or_key + "", data, file);
    }

}

