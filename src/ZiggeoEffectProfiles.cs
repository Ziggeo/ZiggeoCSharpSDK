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
        return this.application.connect().postJSON("/effects/", data, null);
    }

    public JObject index(Dictionary<string,string> data) {
        return this.application.connect().getJSON("/effects/", data);
    }

    public JObject get(string token_or_key) {
        return this.application.connect().getJSON("/effects/" + token_or_key + "", null);
    }

    public Stream delete(string token_or_key) {
        return this.application.connect().delete("/effects/" + token_or_key + "", null);
    }

}

