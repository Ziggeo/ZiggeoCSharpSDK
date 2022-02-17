using System;

public class Ziggeo {

    public string token;
    public string private_key;
    public string encryption_key;
    private ZiggeoConfig configObj;
    private ZiggeoConnect connectObj;
    private ZiggeoConnect apiConnectObj;
    private ZiggeoConnect cdnConnectObj;
    private ZiggeoConnect jsCdnConnectObj;
    private ZiggeoAuth authObj = null;
    private ZiggeoVideos videosObj = null;
    private ZiggeoStreams streamsObj = null;
    private ZiggeoAudios audiosObj = null;
    private ZiggeoAudioStreams audioStreamsObj = null;
    private ZiggeoAuthtokens authtokensObj = null;
    private ZiggeoApplication applicationObj = null;
    private ZiggeoEffectProfiles effectProfilesObj = null;
    private ZiggeoEffectProfileProcess effectProfileProcessObj = null;
    private ZiggeoMetaProfiles metaProfilesObj = null;
    private ZiggeoMetaProfileProcess metaProfileProcessObj = null;
    private ZiggeoWebhooks webhooksObj = null;
    private ZiggeoAnalytics analyticsObj = null;

    public Ziggeo(string token, string private_key, string encryption_key) {
        StringComparison comparison = StringComparison.InvariantCulture;
        this.token = token;
        this.private_key = private_key;
        this.encryption_key = encryption_key;
        this.configObj = new ZiggeoConfig();
        string server_api_url = this.config().server_api_url;
        foreach (string key in this.config().regions.Keys)
            if (this.token.StartsWith(key, comparison))
                server_api_url = this.config().regions[key];
        this.connectObj = new ZiggeoConnect(this, server_api_url, this.configObj);
        string api_url = this.config().api_url;
        foreach (string key in this.config().api_regions.Keys)
            if (this.token.StartsWith(key, comparison))
                api_url = this.config().api_regions[key];
        this.apiConnectObj = new ZiggeoConnect(this, api_url, this.configObj);
        string cdn_url = this.config().cdn_url;
        foreach (string key in this.config().cdn_regions.Keys)
            if (this.token.StartsWith(key, comparison))
                cdn_url = this.config().cdn_regions[key];
        this.cdnConnectObj = new ZiggeoConnect(this, cdn_url, this.configObj);
				string js_cdn_url = this.config().js_cdn_url;
				foreach (string key in this.config().js_cdn_regions.Keys)
						if (this.token.StartsWith(key, comparison))
								js_cdn_url = this.config().js_cdn_regions[key];
				this.jsCdnConnectObj = new ZiggeoConnect(this, js_cdn_url, this.configObj);
    }

    public ZiggeoConfig config() {
        return this.configObj;
    }

    public ZiggeoConnect connect() {
        if (this.connectObj == null)
        {
            StringComparison comparison = StringComparison.InvariantCulture;
            string server_api_url = this.config().server_api_url;
            foreach (string key in this.config().regions.Keys)
                if (this.token.StartsWith(key, comparison))
                    server_api_url = this.config().regions[key];
            this.connectObj = new ZiggeoConnect(this, server_api_url, this.configObj);
        }
        return this.connectObj;
    }

    public ZiggeoConnect apiConnect() {
        if (this.apiConnectObj == null)
            {
            StringComparison comparison = StringComparison.InvariantCulture;
            string api_url = this.config().api_url;
            foreach (string key in this.config().api_regions.Keys)
                if (this.token.StartsWith(key, comparison))
                    api_url = this.config().api_regions[key];
            this.apiConnectObj = new ZiggeoConnect(this, api_url);
        }
        return this.apiConnectObj;
    }

    public ZiggeoConnect cdnConnect() {
        if (this.cdnConnectObj == null)
            {
            StringComparison comparison = StringComparison.InvariantCulture;
            string cdn_url = this.config().cdn_url;
            foreach (string key in this.config().cdn_regions.Keys)
                if (this.token.StartsWith(key, comparison))
                    cdn_url = this.config().cdn_regions[key];
            this.cdnConnectObj = new ZiggeoConnect(this, cdn_url);
        }
        return this.cdnConnectObj;
    }

		public ZiggeoConnect jsCdnConnect() {
				if (this.jsCdnConnectObj == null)
						{
						StringComparison comparison = StringComparison.InvariantCulture;
						string js_cdn_url = this.config().js_cdn_url;
						foreach (string key in this.config().js_cdn_regions.Keys)
								if (this.token.StartsWith(key, comparison))
										js_cdn_url = this.config().js_cdn_regions[key];
						this.jsCdnConnectObj = new ZiggeoConnect(this, js_cdn_url);
				}
				return this.jsCdnConnectObj;
		}

    public ZiggeoAuth auth() {
        if (this.authObj == null)
            this.authObj = new ZiggeoAuth(this);
        return this.authObj;
    }
    public ZiggeoVideos videos() {
        if (this.videosObj == null)
            this.videosObj = new ZiggeoVideos(this);
        return this.videosObj;
    }
    public ZiggeoStreams streams() {
        if (this.streamsObj == null)
            this.streamsObj = new ZiggeoStreams(this);
        return this.streamsObj;
    }
    public ZiggeoAudios audios() {
        if (this.audiosObj == null)
            this.audiosObj = new ZiggeoAudios(this);
        return this.audiosObj;
    }
    public ZiggeoAudioStreams audioStreams() {
        if (this.audioStreamsObj == null)
            this.audioStreamsObj = new ZiggeoAudioStreams(this);
        return this.audioStreamsObj;
    }
    public ZiggeoAuthtokens authtokens() {
        if (this.authtokensObj == null)
            this.authtokensObj = new ZiggeoAuthtokens(this);
        return this.authtokensObj;
    }
    public ZiggeoApplication application() {
        if (this.applicationObj == null)
            this.applicationObj = new ZiggeoApplication(this);
        return this.applicationObj;
    }
    public ZiggeoEffectProfiles effectProfiles() {
        if (this.effectProfilesObj == null)
            this.effectProfilesObj = new ZiggeoEffectProfiles(this);
        return this.effectProfilesObj;
    }
    public ZiggeoEffectProfileProcess effectProfileProcess() {
        if (this.effectProfileProcessObj == null)
            this.effectProfileProcessObj = new ZiggeoEffectProfileProcess(this);
        return this.effectProfileProcessObj;
    }
    public ZiggeoMetaProfiles metaProfiles() {
        if (this.metaProfilesObj == null)
            this.metaProfilesObj = new ZiggeoMetaProfiles(this);
        return this.metaProfilesObj;
    }
    public ZiggeoMetaProfileProcess metaProfileProcess() {
        if (this.metaProfileProcessObj == null)
            this.metaProfileProcessObj = new ZiggeoMetaProfileProcess(this);
        return this.metaProfileProcessObj;
    }
    public ZiggeoWebhooks webhooks() {
        if (this.webhooksObj == null)
            this.webhooksObj = new ZiggeoWebhooks(this);
        return this.webhooksObj;
    }
    public ZiggeoAnalytics analytics() {
        if (this.analyticsObj == null)
            this.analyticsObj = new ZiggeoAnalytics(this);
        return this.analyticsObj;
    }

}