
using System.Collections.Generic;

public class ZiggeoConfig {
	
	public bool local = false;
	public string server_api_url = "https://srvapi.ziggeo.com";
    public IDictionary<string, string> regions;

    public ZiggeoConfig() {
        regions = new Dictionary<string, string>();
                    regions["r1"] = "https://srvapi-eu-west-1.ziggeo.com";
            }

}
