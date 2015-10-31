# Ziggeo C# Server SDK
==================================================

Ziggeo API (http://ziggeo.com) allows you to integrate video recording and playback with only
two lines of code in your site, service or app. This is the C# Server SDK repository.

Pull requests welcome.


## Dependencies

- Newtonsoft.Json


## Client-Side Integration

For the client-side integration, you need to add these assets to your html file:

```html 
<link rel="stylesheet" href="//assets-cdn.ziggeo.com/css/ziggeo-v1.css" /> 
<script src="//assets-csn.ziggeo.com/js/ziggeo-v1.js"></script> 
```

Then, you need to specify your api token:
```html 
<script>
	ZiggeoApi.token = "APPLICATION_TOKEN"; 
</script>
```

You can specify other global options, [see here](http://ziggeo.com/docs#client-integration-header).

To fire up a recorder on your page, add:
```html 
<ziggeo></ziggeo> 
``` 

To embed a player for an existing video, add:
```html 
<ziggeo ziggeo-video='video-token'></ziggeo> 
``` 

For the full documentation, please visit [ziggeo.com](http://ziggeo.com/docs).


## Server-Side Integration

You can integrate the Server SDK as follows:

```csharp 
Ziggeo ziggeo = new Ziggeo("*token*", "*private_key*", "*encryption_key*"); 
```


## Server-Side Methods

### Videos  
 
The videos resource allows you to access all single videos. Each video may contain more than one stream. 
 

#### Index 
 
Query an array of videos (will return at most 50 videos by default). Newest videos come first. 

```csharp 
ziggeo.videos().index(Dictionary<string, string> arguments) 
``` 
 
Arguments 
- limit: *Limit the number of returned videos. Can be set up to 100.* 
- skip: *Skip the first [n] entries.* 
- reverse: *Reverse the order in which videos are returned.* 
- states: *Filter videos by state* 
- tags: *Filter the search result to certain tags* 


#### Get 
 
Get a single video by token or key. 

```csharp 
ziggeo.videos().get(string token_or_key) 
``` 
 


#### Download Video 
 
Download the video data file 

```csharp 
ziggeo.videos().download_video(string token_or_key) 
``` 
 


#### Download Image 
 
Download the image data file 

```csharp 
ziggeo.videos().download_image(string token_or_key) 
``` 
 


#### Update 
 
Update single video by token or key. 

```csharp 
ziggeo.videos().update(string token_or_key, Dictionary<string, string> arguments) 
``` 
 
Arguments 
- min_duration: *Minimal duration of video* 
- max_duration: *Maximal duration of video* 
- tags: *Video Tags* 
- key: *Unique (optional) name of video* 
- volatile: *Automatically removed this video if it remains empty* 
- expiration_days: *After how many days will this video be deleted* 


#### Delete 
 
Delete a single video by token or key. 

```csharp 
ziggeo.videos().delete(string token_or_key) 
``` 
 


#### Create 
 
Create a new video. 

```csharp 
ziggeo.videos().create(Dictionary<string, string> arguments, string file) 
``` 
 
Arguments 
- file: *Video file to be uploaded* 
- min_duration: *Minimal duration of video* 
- max_duration: *Maximal duration of video* 
- tags: *Video Tags* 
- key: *Unique (optional) name of video* 
- volatile: *Automatically removed this video if it remains empty* 


### Streams  
 
The streams resource allows you to directly access all streams associated with a single video. 
 

#### Index 
 
Return all streams associated with a video 

```csharp 
ziggeo.streams().index(string video_token_or_key, Dictionary<string, string> arguments) 
``` 
 
Arguments 
- states: *Filter streams by state* 


#### Get 
 
Get a single stream 

```csharp 
ziggeo.streams().get(string video_token_or_key, string token_or_key) 
``` 
 


#### Download Video 
 
Download the video data associated with the stream 

```csharp 
ziggeo.streams().download_video(string video_token_or_key, string token_or_key) 
``` 
 


#### Download Image 
 
Download the image data associated with the stream 

```csharp 
ziggeo.streams().download_image(string video_token_or_key, string token_or_key) 
``` 
 


#### Delete 
 
Delete the stream 

```csharp 
ziggeo.streams().delete(string video_token_or_key, string token_or_key) 
``` 
 


#### Create 
 
Create a new stream 

```csharp 
ziggeo.streams().create(string video_token_or_key, Dictionary<string, string> arguments, string file) 
``` 
 
Arguments 
- file: *Video file to be uploaded* 


#### Attach Image 
 
Attaches an image to a new stream 

```csharp 
ziggeo.streams().attach_image(string video_token_or_key, string token_or_key, Dictionary<string, string> arguments, string file) 
``` 
 
Arguments 
- file: *Image file to be attached* 


#### Attach Video 
 
Attaches a video to a new stream 

```csharp 
ziggeo.streams().attach_video(string video_token_or_key, string token_or_key, Dictionary<string, string> arguments, string file) 
``` 
 
Arguments 
- file: *Video file to be attached* 


#### Bind 
 
Closes and submits the stream 

```csharp 
ziggeo.streams().bind(string video_token_or_key, string token_or_key, Dictionary<string, string> arguments) 
``` 
 


### Authtokens  
 
The auth token resource allows you to manage authorization settings for video objects. 
 

#### Get 
 
Get a single auth token by token. 

```csharp 
ziggeo.authtokens().get(string token) 
``` 
 


#### Update 
 
Update single auth token by token. 

```csharp 
ziggeo.authtokens().update(string token_or_key, Dictionary<string, string> arguments) 
``` 
 
Arguments 
- volatile: *Will this object automatically be deleted if it remains empty?* 
- hidden: *If hidden, the token cannot be used directly.* 
- expiration_date: *Expiration date for the auth token* 
- usage_experitation_time: *Expiration time per session* 
- session_limit: *Maximal number of sessions* 
- grants: *Permissions this tokens grants* 


#### Delete 
 
Delete a single auth token by token. 

```csharp 
ziggeo.authtokens().delete(string token_or_key) 
``` 
 


#### Create 
 
Create a new auth token. 

```csharp 
ziggeo.authtokens().create(Dictionary<string, string> arguments) 
``` 
 
Arguments 
- volatile: *Will this object automatically be deleted if it remains empty?* 
- hidden: *If hidden, the token cannot be used directly.* 
- expiration_date: *Expiration date for the auth token* 
- usage_experitation_time: *Expiration time per session* 
- session_limit: *Maximal number of sessions* 
- grants: *Permissions this tokens grants* 





## License

Copyright (c) 2013-2015 Ziggeo
 
Apache 2.0 License