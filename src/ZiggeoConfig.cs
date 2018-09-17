
using System.Collections.Generic;

public class ZiggeoConfig {
	
	public string server_api_url = "https://srvapi.ziggeo.com";
    public string api_url = "https://api-us-east-1.ziggeo.com";
    public IDictionary<string, string> regions;
    public IDictionary<string, string> api_regions;

    public ZiggeoConfig() {
        regions = new Dictionary<string, string>();
                    regions["r1"] = "https://srvapi-eu-west-1.ziggeo.com";
                api_regions = new Dictionary<string, string>();
                    api_regions["r1"] = "https://api-eu-west-1.ziggeo.com";
            }

}
