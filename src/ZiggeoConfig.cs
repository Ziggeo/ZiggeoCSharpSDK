
using System.Collections.Generic;

public class ZiggeoConfig {
	
	public string server_api_url = "https://srvapi.ziggeo.com";
    public string api_url = "https://api-us-east-1.ziggeo.com";
    public string cdn_url = "https://video-cdn.ziggeo.com";
    public int request_timeout = 60;
    public int resilience_factor = 5;
    public IDictionary<string, string> regions;
    public IDictionary<string, string> api_regions;
    public IDictionary<string, string> cdn_regions;
    public IDictionary<string, string> resilience_onfail;
    public IDictionary<string, string> info;

    public ZiggeoConfig() {
        regions = new Dictionary<string, string>();
        regions["r1"] = "https://srvapi-eu-west-1.ziggeo.com";
        api_regions = new Dictionary<string, string>();
        api_regions["r1"] = "https://api-eu-west-1.ziggeo.com";
        cdn_regions = new Dictionary<string, string>();
        cdn_regions["r1"] = "https://video-cdn-eu-west-1.ziggeo.com";
        resilience_onfail = new Dictionary<string, string>();
        resilience_onfail["error"] = "Too many failed attempts";
        info = new Dictionary<string, string>();
        info["progress_show"] = "no";
        info["progress_multiplier"] = "1048576";
        info["progress_desc"] = "mb";
    }
}
