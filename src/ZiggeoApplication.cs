using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class ZiggeoApplication {

    private Ziggeo application;

    public ZiggeoApplication(Ziggeo application) {
        this.application = application;
    }

    public JObject get() {
        return this.application.connect().getJSON("/v1/application", null);
    }

    public JObject update(Dictionary<string,string> data) {
        return this.application.connect().postJSON("/v1/application", data, null);
    }

    public JObject get_stats(Dictionary<string,string> data) {
        return this.application.apiConnect().getJSON("/server/v1/application/stats", data);
    }

}

