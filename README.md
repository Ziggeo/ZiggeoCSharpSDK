# Ziggeo C# Server SDK 0.1.7

Ziggeo API (https://ziggeo.com) allows you to integrate video recording and playback with only
two lines of code in your site, service or app. This is the C# Server SDK repository.

Pull requests welcome.


## Dependencies

- Newtonsoft.Json


## Client-Side Integration

For the client-side integration, you need to add these assets to your html file:

```html 
<link rel="stylesheet" href="//assets-cdn.ziggeo.com/v2-stable/ziggeo.css" />
<script src="//assets-cdn.ziggeo.com/v2-stable/ziggeo.js"></script>
```

Then, you need to specify your api token:
```html 
<script>
    var ziggeoApplication = new ZiggeoApi.V2.Application({
        token: "APPLICATION_TOKEN"
    });
</script>
```

You can specify other global options, [see here](https://ziggeo.com/docs).

To fire up a recorder on your page, add:
```html 
<ziggeorecorder></ziggeorecorder>
``` 

To embed a player for an existing video, add:
```html 
<ziggeoplayer ziggeo-video='video-token'></ziggeoplayer>
``` 

For the full documentation, please visit [ziggeo.com](https://ziggeo.com/docs).



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
- tags: *Filter the search result to certain tags, encoded as a comma-separated string* 


#### Count 
 
Get the video count for the application. 

```csharp 
ziggeo.videos().count(Dictionary<string, string> arguments) 
``` 
 
Arguments 
- states: *Filter videos by state* 
- tags: *Filter the search result to certain tags, encoded as a comma-separated string* 


#### Get 
 
Get a single video by token or key. 

```csharp 
ziggeo.videos().get(string token_or_key) 
``` 
 


#### Get Bulk 
 
Get multiple videos by tokens or keys. 

```csharp 
ziggeo.videos().get_bulk(Dictionary<string, string> arguments) 
``` 
 
Arguments 
- tokens_or_keys: *Comma-separated list with the desired videos tokens or keys (Limit: 100 tokens or keys).* 


#### Stats Bulk 
 
Get stats for multiple videos by tokens or keys. 

```csharp 
ziggeo.videos().stats_bulk(Dictionary<string, string> arguments) 
``` 
 
Arguments 
- tokens_or_keys: *Comma-separated list with the desired videos tokens or keys (Limit: 100 tokens or keys).* 
- summarize: *Boolean. Set it to TRUE to get the stats summarized. Set it to FALSE to get the stats for each video in a separate array. Default: TRUE.* 


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
 


#### Get Stats 
 
Get the video's stats 

```csharp 
ziggeo.videos().get_stats(string token_or_key) 
``` 
 


#### Push To Service 
 
Push a video to a provided push service. 

```csharp 
ziggeo.videos().push_to_service(string token_or_key, Dictionary<string, string> arguments) 
``` 
 
Arguments 
- pushservicetoken: *Push Services's token (from the Push Services configured for the app)* 


#### Apply Effect 
 
Apply an effect profile to a video. 

```csharp 
ziggeo.videos().apply_effect(string token_or_key, Dictionary<string, string> arguments) 
``` 
 
Arguments 
- effectprofiletoken: *Effect Profile token (from the Effect Profiles configured for the app)* 


#### Apply Meta 
 
Apply a meta profile to a video. 

```csharp 
ziggeo.videos().apply_meta(string token_or_key, Dictionary<string, string> arguments) 
``` 
 
Arguments 
- metaprofiletoken: *Meta Profile token (from the Meta Profiles configured for the app)* 


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


#### Update Bulk 
 
Update multiple videos by token or key. 

```csharp 
ziggeo.videos().update_bulk(Dictionary<string, string> arguments) 
``` 
 
Arguments 
- tokens_or_keys: *Comma-separated list with the desired videos tokens or keys (Limit: 100 tokens or keys).* 
- min_duration: *Minimal duration of video* 
- max_duration: *Maximal duration of video* 
- tags: *Video Tags* 
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


#### Analytics 
 
Get analytics for a specific videos with the given params 

```csharp 
ziggeo.videos().analytics(string token_or_key, Dictionary<string, string> arguments) 
``` 
 
Arguments 
- from: *A UNIX timestamp in microseconds used as the start date of the query* 
- to: *A UNIX timestamp in microseconds used as the end date of the query* 
- date: *A UNIX timestamp in microseconds to retrieve data from a single date. If set, it overwrites the from and to params.* 
- query: *The query you want to run. It can be one of the following: device_views_by_os, device_views_by_date, total_plays_by_country, full_plays_by_country, total_plays_by_hour, full_plays_by_hour, total_plays_by_browser, full_plays_by_browser* 


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
 


#### Push To Service 
 
Push a stream to a provided push service. 

```csharp 
ziggeo.streams().push_to_service(string video_token_or_key, string token_or_key, Dictionary<string, string> arguments) 
``` 
 
Arguments 
- pushservicetoken: *Push Services's token (from the Push Services configured for the app)* 


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


### EffectProfiles  

The effect profiles resource allows you to access and create effect profiles for your app. Each effect profile may contain one process or more. 
 

#### Create 
 
Create a new effect profile. 

```csharp 
ziggeo.effectProfiles().create(Dictionary<string, string> arguments) 
``` 
 
Arguments 
- key: *Effect profile key.* 
- title: *Effect profile title.* 


#### Index 
 
Get list of effect profiles. 

```csharp 
ziggeo.effectProfiles().index(Dictionary<string, string> arguments) 
``` 
 
Arguments 
- limit: *Limit the number of returned effect profiles. Can be set up to 100.* 
- skip: *Skip the first [n] entries.* 
- reverse: *Reverse the order in which effect profiles are returned.* 


#### Get 
 
Get a single effect profile 

```csharp 
ziggeo.effectProfiles().get(string token_or_key) 
``` 
 


#### Delete 
 
Delete the effect profile 

```csharp 
ziggeo.effectProfiles().delete(string token_or_key) 
``` 
 


### EffectProfileProcess  

The process resource allows you to directly access all process associated with a single effect profile. 
 

#### Index 
 
Return all processes associated with a effect profile 

```csharp 
ziggeo.effectProfileProcess().index(string effect_token_or_key, Dictionary<string, string> arguments) 
``` 
 
Arguments 
- states: *Filter streams by state* 


#### Get 
 
Get a single process 

```csharp 
ziggeo.effectProfileProcess().get(string effect_token_or_key, string token_or_key) 
``` 
 


#### Delete 
 
Delete the process 

```csharp 
ziggeo.effectProfileProcess().delete(string effect_token_or_key, string token_or_key) 
``` 
 


#### Create Filter Process 
 
Create a new filter effect process 

```csharp 
ziggeo.effectProfileProcess().create_filter_process(string effect_token_or_key, Dictionary<string, string> arguments) 
``` 
 
Arguments 
- effect: *Effect to be applied in the process* 


#### Create Watermark Process 
 
Attaches an image to a new stream 

```csharp 
ziggeo.effectProfileProcess().create_watermark_process(string effect_token_or_key, Dictionary<string, string> arguments, string file) 
``` 
 
Arguments 
- file: *Image file to be attached* 
- vertical: *Specify the vertical position of your watermark (a value between 0.0 and 1.0)* 
- horizontal: *Specify the horizontal position of your watermark (a value between 0.0 and 1.0)* 
- scale: *Specify the image scale of your watermark (a value between 0.0 and 1.0)* 


### MetaProfiles  

The meta profiles resource allows you to access and create meta profiles for your app. Each meta profile may contain one process or more. 
 

#### Create 
 
Create a new meta profile. 

```csharp 
ziggeo.metaProfiles().create(Dictionary<string, string> arguments) 
``` 
 
Arguments 
- key: *Meta Profile profile key.* 
- title: *Meta Profile profile title.* 


#### Index 
 
Get list of meta profiles. 

```csharp 
ziggeo.metaProfiles().index(Dictionary<string, string> arguments) 
``` 
 
Arguments 
- limit: *Limit the number of returned meta profiles. Can be set up to 100.* 
- skip: *Skip the first [n] entries.* 
- reverse: *Reverse the order in which meta profiles are returned.* 


#### Get 
 
Get a single meta profile 

```csharp 
ziggeo.metaProfiles().get(string token_or_key) 
``` 
 


#### Delete 
 
Delete the meta profile 

```csharp 
ziggeo.metaProfiles().delete(string token_or_key) 
``` 
 


### MetaProfileProcess  

The process resource allows you to directly access all process associated with a single meta profile. 
 

#### Index 
 
Return all processes associated with a meta profile 

```csharp 
ziggeo.metaProfileProcess().index(string meta_token_or_key) 
``` 
 


#### Get 
 
Get a single process 

```csharp 
ziggeo.metaProfileProcess().get(string meta_token_or_key, string token_or_key) 
``` 
 


#### Delete 
 
Delete the process 

```csharp 
ziggeo.metaProfileProcess().delete(string meta_token_or_key, string token_or_key) 
``` 
 


#### Create Video Analysis Process 
 
Create a new video analysis meta process 

```csharp 
ziggeo.metaProfileProcess().create_video_analysis_process(string meta_token_or_key) 
``` 
 


#### Create Audio Transcription Process 
 
Create a new audio transcription meta process 

```csharp 
ziggeo.metaProfileProcess().create_audio_transcription_process(string meta_token_or_key) 
``` 
 


#### Create Nsfw Process 
 
Create a new nsfw filter meta process 

```csharp 
ziggeo.metaProfileProcess().create_nsfw_process(string meta_token_or_key, Dictionary<string, string> arguments) 
``` 
 
Arguments 
- nsfw_action: *One of the following three: approve, reject, nothing.* 


### Webhooks  

The webhooks resource allows you to create or delete webhooks related to a given application. 
 

#### Create 
 
Create a new webhook for the given url to catch the given events. 

```csharp 
ziggeo.webhooks().create(Dictionary<string, string> arguments) 
``` 
 
Arguments 
- target_url: *The url that will catch the events* 
- encoding: *Data encoding to be used by the webhook to send the events.* 
- events: *Comma-separated list of the events the webhook will catch. They must be valid webhook type events.* 


#### Delete 
 
Delete a webhook using its URL. 

```csharp 
ziggeo.webhooks().delete(Dictionary<string, string> arguments) 
``` 
 
Arguments 
- target_url: *The url that will catch the events* 


### Analytics  

The analytics resource allows you to access the analytics for the given application 
 

#### Get 
 
Get analytics for the given params 

```csharp 
ziggeo.analytics().get(Dictionary<string, string> arguments) 
``` 
 
Arguments 
- from: *A UNIX timestamp in microseconds used as the start date of the query* 
- to: *A UNIX timestamp in microseconds used as the end date of the query* 
- date: *A UNIX timestamp in microseconds to retrieve data from a single date. If set, it overwrites the from and to params.* 
- query: *The query you want to run. It can be one of the following: device_views_by_os, device_views_by_date, total_plays_by_country, full_plays_by_country, total_plays_by_hour, full_plays_by_hour, total_plays_by_browser, full_plays_by_browser* 





## License

Copyright (c) 2013-2018 Ziggeo
 
Apache 2.0 License
