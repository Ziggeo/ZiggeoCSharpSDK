using System;

public class Ziggeo {

    public string token;
    public string private_key;
    public string encryption_key;
    private ZiggeoConfig configObj;
    private ZiggeoConnect connectObj;
    private ZiggeoConnect apiConnectObj;
    private ZiggeoAuth authObj = null;
    private ZiggeoVideos videosObj = null;
    private ZiggeoStreams streamsObj = null;
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
        this.connectObj = new ZiggeoConnect(this, server_api_url);
        string api_url = this.config().api_url;
        foreach (string key in this.config().api_regions.Keys)
            if (this.token.StartsWith(key, comparison))
                api_url = this.config().api_regions[key];
        this.apiConnectObj = new ZiggeoConnect(this, api_url);
    }

    public ZiggeoConfig config() {
        return this.configObj;
    }

    public ZiggeoConnect connect() {
        return this.connectObj;
    }

    public ZiggeoConnect apiConnect() {
        return this.apiConnectObj;
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