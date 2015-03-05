using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class ZiggeoAuthtokens {

    private Ziggeo application;

    public ZiggeoAuthtokens(Ziggeo application) {
        this.application = application;
    }

    public JObject get(string token) {
        return this.application.connect().getJSON("/authtokens/" + token + "", null);
    }

    public JObject update(string token_or_key, Dictionary<string,string> data) {
        return this.application.connect().postJSON("/authtokens/" + token_or_key + "", data, null);
    }

    public Stream delete(string token_or_key) {
        return this.application.connect().delete("/authtokens/" + token_or_key + "", null);
    }

    public JObject create(Dictionary<string,string> data) {
        return this.application.connect().postJSON("/authtokens/", data, null);
    }

}

