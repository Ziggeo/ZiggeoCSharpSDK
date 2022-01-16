using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class ZiggeoEffectProfiles {

    private Ziggeo application;

    public ZiggeoEffectProfiles(Ziggeo application) {
        this.application = application;
    }

    public JObject create(Dictionary<string,string> data) {
        return this.application.connect().postJSON("/v1/effects/", data, null);
    }

    public JArray index(Dictionary<string,string> data) {
        return this.application.connect().getJSONArray("/v1/effects/", data);
    }

    public JObject get(string token_or_key) {
        return this.application.connect().getJSON("/v1/effects/" + token_or_key + "", null);
    }

    public Stream delete(string token_or_key) {
        return this.application.connect().delete("/v1/effects/" + token_or_key + "", null);
    }

    public JObject update(string token_or_key, Dictionary<string,string> data) {
        return this.application.connect().postJSON("/v1/effects/" + token_or_key + "", data, null);
    }

}

