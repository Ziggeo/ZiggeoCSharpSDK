using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class ZiggeoAnalytics {

    private Ziggeo application;

    public ZiggeoAnalytics(Ziggeo application) {
        this.application = application;
    }

    public JObject get(Dictionary<string,string> data) {
        return this.application.connect().postJSON("/v1/analytics/get", data, null);
    }

}

