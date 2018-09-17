using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class ZiggeoWebhooks {

    private Ziggeo application;

    public ZiggeoWebhooks(Ziggeo application) {
        this.application = application;
    }

    public Stream create(Dictionary<string,string> data) {
        return this.application.connect().post("/v1/api/hook", data, null);
    }

    public Stream delete(Dictionary<string,string> data) {
        return this.application.connect().post("/v1/api/removehook", data, null);
    }

}

