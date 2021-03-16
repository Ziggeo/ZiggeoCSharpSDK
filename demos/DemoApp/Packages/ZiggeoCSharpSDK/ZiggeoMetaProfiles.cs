using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class ZiggeoMetaProfiles {

    private Ziggeo application;

    public ZiggeoMetaProfiles(Ziggeo application) {
        this.application = application;
    }

    public JObject create(Dictionary<string,string> data) {
        return this.application.connect().postJSON("/v1/metaprofiles/", data, null);
    }

    public JObject index(Dictionary<string,string> data) {
        return this.application.connect().getJSON("/v1/metaprofiles/", data);
    }

    public JObject get(string token_or_key) {
        return this.application.connect().getJSON("/v1/metaprofiles/" + token_or_key + "", null);
    }

    public Stream delete(string token_or_key) {
        return this.application.connect().delete("/v1/metaprofiles/" + token_or_key + "", null);
    }

}

