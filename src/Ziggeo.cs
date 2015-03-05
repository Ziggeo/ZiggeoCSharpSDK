public class Ziggeo {
	
	public string token;
	public string private_key;
	public string encryption_key;
	private ZiggeoConfig configObj;
	private ZiggeoConnect connectObj;
	private ZiggeoVideos videosObj = null;
	private ZiggeoStreams streamsObj = null;
	private ZiggeoAuthtokens authtokensObj = null;
	
	public Ziggeo(string token, string private_key, string encryption_key) {
		this.token = token;
		this.private_key = private_key;
		this.encryption_key = encryption_key;
		this.configObj = new ZiggeoConfig();
		this.connectObj = new ZiggeoConnect(this);
	}
	
	public ZiggeoConfig config() {
		return this.configObj;
	}
	
	public ZiggeoConnect connect() {
		return this.connectObj;
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
	
}