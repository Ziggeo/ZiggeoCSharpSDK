# Ziggeo's C# Server SDK

latest version: **0.1.30**

## Index

1. [Why Ziggeo's C# Server Side SDK?](#why-us)
2. [Prerequisites](#prerequisites)
    1. [Download](#download)
    2. [How to use](#how-to-use)
    3. [Dependencies](#dependencies)
3. [Client-Side Integration](#codes-client-side)
4. [Server-Side Integration](#codes-server-side)
    1. [Init](#codes-init)
    2. [Available Methods](#codes-methods)
    3. [Methods for Videos](#method-videos)
        1. [Videos Index](#method-videos-index)
        2. [Videos Count](#method-videos-count)
        3. [Videos Get](#method-videos-get)
        4. [Videos Get Bulk](#method-videos-get-bulk)
        5. [Videos Stats Bulk](#method-videos-stats-bulk)
        6. [Videos Download Video](#method-videos-download-video)
        7. [Videos Download Image](#method-videos-download-image)
        8. [Videos Get Stats](#method-videos-get-stats)
        9. [Videos Push To Service](#method-videos-push-to-service)
        10. [Videos Apply Effect](#method-videos-apply-effect)
        11. [Videos Apply Meta](#method-videos-apply-meta)
        12. [Videos Update](#method-videos-update)
        13. [Videos Update Bulk](#method-videos-update-bulk)
        14. [Videos Delete](#method-videos-delete)
        15. [Videos Create](#method-videos-create)
        16. [Videos Analytics](#method-videos-analytics)
    4. [Methods for Streams](#method-streams)
        1. [Streams Index](#method-streams-index)
        2. [Streams Get](#method-streams-get)
        3. [Streams Download Video](#method-streams-download-video)
        4. [Streams Download Image](#method-streams-download-image)
        5. [Streams Push To Service](#method-streams-push-to-service)
        6. [Streams Delete](#method-streams-delete)
        7. [Streams Create](#method-streams-create)
        8. [Streams Attach Image](#method-streams-attach-image)
        9. [Streams Attach Video](#method-streams-attach-video)
        10. [Streams Attach Subtitle](#method-streams-attach-subtitle)
    5. [Methods for Audios](#method-audios)
        1. [Audios Index](#method-audios-index)
        2. [Audios Count](#method-audios-count)
        3. [Audios Get](#method-audios-get)
        4. [Audios Get Bulk](#method-audios-get-bulk)
        5. [Audios Download Audio](#method-audios-download-audio)
        6. [Audios Update](#method-audios-update)
        7. [Audios Update Bulk](#method-audios-update-bulk)
        8. [Audios Delete](#method-audios-delete)
        9. [Audios Create](#method-audios-create)
    6. [Methods for Audio Streams](#method-audio-streams)
        1. [Audio Streams Index](#method-audio-streams-index)
        2. [Audio Streams Get](#method-audio-streams-get)
        3. [Audio Streams Download Audio](#method-audio-streams-download-audio)
        4. [Audio Streams Delete](#method-audio-streams-delete)
        5. [Audio Streams Create](#method-audio-streams-create)
    7. [Methods for Authtokens](#method-authtokens)
        1. [Authtokens Get](#method-authtokens-get)
        2. [Authtokens Update](#method-authtokens-update)
        3. [Authtokens Delete](#method-authtokens-delete)
        4. [Authtokens Create](#method-authtokens-create)
    8. [Methods for Application](#method-application)
        1. [Application Get](#method-application-get)
        2. [Application Update](#method-application-update)
        3. [Application Get Stats](#method-application-get-stats)
    9. [Methods for Effect Profiles](#method-effect-profiles)
        1. [Effect Profiles Create](#method-effect-profiles-create)
        2. [Effect Profiles Index](#method-effect-profiles-index)
        3. [Effect Profiles Get](#method-effect-profiles-get)
        4. [Effect Profiles Delete](#method-effect-profiles-delete)
        5. [Effect Profiles Update](#method-effect-profiles-update)
    10. [Methods for Effect Profile Process](#method-effect-profile-process)
        1. [Effect Profile Process Index](#method-effect-profile-process-index)
        2. [Effect Profile Process Get](#method-effect-profile-process-get)
        3. [Effect Profile Process Delete](#method-effect-profile-process-delete)
        4. [Effect Profile Process Create Filter Process](#method-effect-profile-process-create-filter-process)
        5. [Effect Profile Process Create Watermark Process](#method-effect-profile-process-create-watermark-process)
        6. [Effect Profile Process Edit Watermark Process](#method-effect-profile-process-edit-watermark-process)
    11. [Methods for Meta Profiles](#method-meta-profiles)
        1. [Meta Profiles Create](#method-meta-profiles-create)
        2. [Meta Profiles Index](#method-meta-profiles-index)
        3. [Meta Profiles Get](#method-meta-profiles-get)
        4. [Meta Profiles Delete](#method-meta-profiles-delete)
    12. [Methods for Meta Profile Process](#method-meta-profile-process)
        1. [Meta Profile Process Index](#method-meta-profile-process-index)
        2. [Meta Profile Process Get](#method-meta-profile-process-get)
        3. [Meta Profile Process Delete](#method-meta-profile-process-delete)
        4. [Meta Profile Process Create Video Analysis Process](#method-meta-profile-process-create-video-analysis-process)
        5. [Meta Profile Process Create Audio Transcription Process](#method-meta-profile-process-create-audio-transcription-process)
        6. [Meta Profile Process Create Nsfw Process](#method-meta-profile-process-create-nsfw-process)
        7. [Meta Profile Process Create Profanity Process](#method-meta-profile-process-create-profanity-process)
    13. [Methods for Webhooks](#method-webhooks)
        1. [Webhooks Create](#method-webhooks-create)
        2. [Webhooks Confirm](#method-webhooks-confirm)
        3. [Webhooks Delete](#method-webhooks-delete)
    14. [Methods for Analytics](#method-analytics)
        1. [Analytics Get](#method-analytics-get)
5. [License](#license)


## Why Ziggeo's C# Server Side SDK? <a name="why-us"></a>

[Ziggeo](https://ziggeo.com) is a powerfull, whitelabel video SAAS with a goal to help people with their video revolution. And what better way to do it than with an award winning multimedia API.

This server side SDK is designed to help you ease the communication with Ziggeo API. In that it allows you to privately communicate between your server and our server through requests of what you want to happen.

It offers you pre-built functionality to call and manipulate and there are demos in /demos/ directory for you to check out and use as starting point.

### Who it is for?

1. Do you have a system that requires calls to be made which should not be seen on client side?
2. Want to have an easier time handling the media as it comes to your server?
3. Want something that is simple and easy to use?
4. You need some powerful features high end video services provide?

If any of the above is "Yes" then you are in the right place as this SDK is for you!

## Prerequisites <a name="prerequisites"></a>

### Download <a name="download"></a>

You will want to either download the SDK zip file or to pull it in as git repository into your own project.

To clone it you would go into your project folder and then
```csharp    git clone https://github.com/Ziggeo/ZiggeoCSharpSdk```

### How to use <a name="how-to-use"></a>

To start using the C# SDK you would need to initialize the Ziggeo class with application token, private token and possibly encryption token. The token and keys can be found within the Ziggeo application once you log into your account, under Overview page.


### Dependencies<a name="dependencies"></a>


-Newtonsoft.Json
## Client-Side Integration<a name="codes-client-side"></a>

For the client-side integration, you need to add these assets to your html file:

```html 
<link rel="stylesheet" href="//assets-cdn.ziggeo.com/v2-stable/ziggeo.css" />
<script src="//assets-cdn.ziggeo.com/v2-stable/ziggeo.js"></script>
```

Then, you need to specify your api token:
```html 
<script>
    var ziggeoApplication = new ZiggeoApi.V2.Application({
        token: "APPLICATION_TOKEN",
        webrtc_streaming_if_necessary: true,
        webrtc_on_mobile: true
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

## Server-Side Integration<a name="codes-server-side"></a>

### Initialize Ziggeo class in your code<a name="codes-init"></a>

You can integrate the Server SDK as follows:

```csharp 
Ziggeo ziggeo = new Ziggeo("*token*", "*private_key*", "*encryption_key*"); 
```

Config is optional and if not specified (recommended), the Config file will be used instead.

### Available Methods<a name="codes-methods"></a>

Currently available methods are branched off within different categories:

1. Videos
2. Streams
3. Audios
4. Audio Streams
5. Authtokens
6. Application
7. Effect Profiles
8. Effect Profile Process
9. Meta Profiles
10. Meta Profile Process
11. Webhooks
12. Analytics

Each of this sections has their own actions and they are explained bellow



### Videos<a name="method-videos"></a>


The videos resource allows you to access all single videos. Each video may contain more than one stream.

#### Index<a name="method-videos-index"></a>

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

#### Count<a name="method-videos-count"></a>

Get the video count for the application.

```csharp
ziggeo.videos().count(Dictionary<string, string> arguments)
```

 Arguments
- states: *Filter videos by state*
- tags: *Filter the search result to certain tags, encoded as a comma-separated string*

#### Get<a name="method-videos-get"></a>

Get a single video by token or key.

```csharp
ziggeo.videos().get(string token_or_key)
```

#### Get Bulk<a name="method-videos-get-bulk"></a>

Get multiple videos by tokens or keys.

```csharp
ziggeo.videos().get_bulk(Dictionary<string, string> arguments)
```

 Arguments
- tokens_or_keys: *Comma-separated list with the desired videos tokens or keys (Limit: 100 tokens or keys).*

#### Stats Bulk<a name="method-videos-stats-bulk"></a>

Get stats for multiple videos by tokens or keys.

```csharp
ziggeo.videos().stats_bulk(Dictionary<string, string> arguments)
```

 Arguments
- tokens_or_keys: *Comma-separated list with the desired videos tokens or keys (Limit: 100 tokens or keys).*
- summarize: *Boolean. Set it to TRUE to get the stats summarized. Set it to FALSE to get the stats for each video in a separate array. Default: TRUE.*

#### Download Video<a name="method-videos-download-video"></a>

Download the video data file

```csharp
ziggeo.videos().download_video(string token_or_key)
```

#### Download Image<a name="method-videos-download-image"></a>

Download the image data file

```csharp
ziggeo.videos().download_image(string token_or_key)
```

#### Get Stats<a name="method-videos-get-stats"></a>

Get the video's stats

```csharp
ziggeo.videos().get_stats(string token_or_key)
```

#### Push To Service<a name="method-videos-push-to-service"></a>

Push a video to a provided push service.

```csharp
ziggeo.videos().push_to_service(string token_or_key, Dictionary<string, string> arguments)
```

 Arguments
- pushservicetoken: *Push Services's token (from the Push Services configured for the app)*

#### Apply Effect<a name="method-videos-apply-effect"></a>

Apply an effect profile to a video.

```csharp
ziggeo.videos().apply_effect(string token_or_key, Dictionary<string, string> arguments)
```

 Arguments
- effectprofiletoken: *Effect Profile token (from the Effect Profiles configured for the app)*

#### Apply Meta<a name="method-videos-apply-meta"></a>

Apply a meta profile to a video.

```csharp
ziggeo.videos().apply_meta(string token_or_key, Dictionary<string, string> arguments)
```

 Arguments
- metaprofiletoken: *Meta Profile token (from the Meta Profiles configured for the app)*

#### Update<a name="method-videos-update"></a>

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
- expire_on: *On which date will this video be deleted. String in ISO 8601 format: YYYY-MM-DD*

#### Update Bulk<a name="method-videos-update-bulk"></a>

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
- expire_on: *On which date will this video be deleted. String in ISO 8601 format: YYYY-MM-DD*

#### Delete<a name="method-videos-delete"></a>

Delete a single video by token or key.

```csharp
ziggeo.videos().delete(string token_or_key)
```

#### Create<a name="method-videos-create"></a>

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
- effect_profile: *Set the effect profile that you want to have applied to your video.*
- meta_profile: *Set the meta profile that you want to have applied to your video once created.*
- video_profile: *Set the video profile that you want to have applied to your video as you create it.*

#### Analytics<a name="method-videos-analytics"></a>

Get analytics for a specific videos with the given params

```csharp
ziggeo.videos().analytics(string token_or_key, Dictionary<string, string> arguments)
```

 Arguments
- from: *A UNIX timestamp in microseconds used as the start date of the query*
- to: *A UNIX timestamp in microseconds used as the end date of the query*
- date: *A UNIX timestamp in microseconds to retrieve data from a single date. If set, it overwrites the from and to params.*
- query: *The query you want to run. It can be one of the following: device_views_by_os, device_views_by_date, total_plays_by_country, full_plays_by_country, total_plays_by_hour, full_plays_by_hour, total_plays_by_browser, full_plays_by_browser*

### Streams<a name="method-streams"></a>


The streams resource allows you to directly access all streams associated with a single video.

#### Index<a name="method-streams-index"></a>

Return all streams associated with a video

```csharp
ziggeo.streams().index(string video_token_or_key, Dictionary<string, string> arguments)
```

 Arguments
- states: *Filter streams by state*

#### Get<a name="method-streams-get"></a>

Get a single stream

```csharp
ziggeo.streams().get(string video_token_or_key, string token_or_key)
```

#### Download Video<a name="method-streams-download-video"></a>

Download the video data associated with the stream

```csharp
ziggeo.streams().download_video(string video_token_or_key, string token_or_key)
```

#### Download Image<a name="method-streams-download-image"></a>

Download the image data associated with the stream

```csharp
ziggeo.streams().download_image(string video_token_or_key, string token_or_key)
```

#### Push To Service<a name="method-streams-push-to-service"></a>

Push a stream to a provided push service.

```csharp
ziggeo.streams().push_to_service(string video_token_or_key, string token_or_key, Dictionary<string, string> arguments)
```

 Arguments
- pushservicetoken: *Push Services's token (from the Push Services configured for the app)*

#### Delete<a name="method-streams-delete"></a>

Delete the stream

```csharp
ziggeo.streams().delete(string video_token_or_key, string token_or_key)
```

#### Create<a name="method-streams-create"></a>

Create a new stream

```csharp
ziggeo.streams().create(string video_token_or_key, Dictionary<string, string> arguments, string file)
```

 Arguments
- file: *Video file to be uploaded*

#### Attach Image<a name="method-streams-attach-image"></a>

Attaches an image to a new stream. Must be attached before video, since video upload triggers the transcoding job and binds the stream

```csharp
ziggeo.streams().attach_image(string video_token_or_key, string token_or_key, Dictionary<string, string> arguments, string file)
```

 Arguments
- file: *Image file to be attached*

#### Attach Video<a name="method-streams-attach-video"></a>

Attaches a video to a new stream

```csharp
ziggeo.streams().attach_video(string video_token_or_key, string token_or_key, Dictionary<string, string> arguments, string file)
```

 Arguments
- file: *Video file to be attached*

#### Attach Subtitle<a name="method-streams-attach-subtitle"></a>

Attaches a subtitle to the stream.

```csharp
ziggeo.streams().attach_subtitle(string video_token_or_key, string token_or_key, Dictionary<string, string> arguments)
```

 Arguments
- lang: *Subtitle language*
- label: *Subtitle reference*
- data: *Actual subtitle*

### Audios<a name="method-audios"></a>


The audios resource allows you to access all single audios. Each video may contain more than one stream.

#### Index<a name="method-audios-index"></a>

Query an array of audios (will return at most 50 audios by default). Newest audios come first.

```csharp
ziggeo.audios().index(Dictionary<string, string> arguments)
```

 Arguments
- limit: *Limit the number of returned audios. Can be set up to 100.*
- skip: *Skip the first [n] entries.*
- reverse: *Reverse the order in which audios are returned.*
- states: *Filter audios by state*
- tags: *Filter the search result to certain tags, encoded as a comma-separated string*

#### Count<a name="method-audios-count"></a>

Get the audio count for the application.

```csharp
ziggeo.audios().count(Dictionary<string, string> arguments)
```

 Arguments
- states: *Filter audios by state*
- tags: *Filter the search result to certain tags, encoded as a comma-separated string*

#### Get<a name="method-audios-get"></a>

Get a single audio by token or key.

```csharp
ziggeo.audios().get(string token_or_key)
```

#### Get Bulk<a name="method-audios-get-bulk"></a>

Get multiple audios by tokens or keys.

```csharp
ziggeo.audios().get_bulk(Dictionary<string, string> arguments)
```

 Arguments
- tokens_or_keys: *Comma-separated list with the desired audios tokens or keys (Limit: 100 tokens or keys).*

#### Download Audio<a name="method-audios-download-audio"></a>

Download the audio data file

```csharp
ziggeo.audios().download_audio(string token_or_key)
```

#### Update<a name="method-audios-update"></a>

Update single audio by token or key.

```csharp
ziggeo.audios().update(string token_or_key, Dictionary<string, string> arguments)
```

 Arguments
- min_duration: *Minimal duration of audio*
- max_duration: *Maximal duration of audio*
- tags: *Audio Tags*
- key: *Unique (optional) name of audio*
- volatile: *Automatically removed this audio if it remains empty*
- expiration_days: *After how many days will this audio be deleted*
- expire_on: *On which date will this audio be deleted. String in ISO 8601 format: YYYY-MM-DD*

#### Update Bulk<a name="method-audios-update-bulk"></a>

Update multiple audios by token or key.

```csharp
ziggeo.audios().update_bulk(Dictionary<string, string> arguments)
```

 Arguments
- tokens_or_keys: *Comma-separated list with the desired audios tokens or keys (Limit: 100 tokens or keys).*
- min_duration: *Minimal duration of audio*
- max_duration: *Maximal duration of audio*
- tags: *Audio Tags*
- volatile: *Automatically removed this audio if it remains empty*
- expiration_days: *After how many days will this audio be deleted*
- expire_on: *On which date will this audio be deleted. String in ISO 8601 format: YYYY-MM-DD*

#### Delete<a name="method-audios-delete"></a>

Delete a single audio by token or key.

```csharp
ziggeo.audios().delete(string token_or_key)
```

#### Create<a name="method-audios-create"></a>

Create a new audio.

```csharp
ziggeo.audios().create(Dictionary<string, string> arguments, string file)
```

 Arguments
- file: *Audio file to be uploaded*
- min_duration: *Minimal duration of audio*
- max_duration: *Maximal duration of audio*
- tags: *Audio Tags*
- key: *Unique (optional) name of audio*
- volatile: *Automatically removed this video if it remains empty*

### Audio Streams<a name="method-audio-streams"></a>


The streams resource allows you to directly access all streams associated with a single audio.

#### Index<a name="method-audio-streams-index"></a>

Return all streams associated with a audio

```csharp
ziggeo.audioStreams().index(string audio_token_or_key, Dictionary<string, string> arguments)
```

 Arguments
- states: *Filter streams by state*

#### Get<a name="method-audio-streams-get"></a>

Get a single stream

```csharp
ziggeo.audioStreams().get(string audio_token_or_key, string token_or_key)
```

#### Download Audio<a name="method-audio-streams-download-audio"></a>

Download the audio data associated with the stream

```csharp
ziggeo.audioStreams().download_audio(string audio_token_or_key, string token_or_key)
```

#### Delete<a name="method-audio-streams-delete"></a>

Delete the stream

```csharp
ziggeo.audioStreams().delete(string audio_token_or_key, string token_or_key)
```

#### Create<a name="method-audio-streams-create"></a>

Create a new stream

```csharp
ziggeo.audioStreams().create(string audio_token_or_key, Dictionary<string, string> arguments, string file)
```

 Arguments
- file: *Audio file to be uploaded*

### Authtokens<a name="method-authtokens"></a>


The auth token resource allows you to manage authorization settings for video objects.

#### Get<a name="method-authtokens-get"></a>

Get a single auth token by token.

```csharp
ziggeo.authtokens().get(string token)
```

#### Update<a name="method-authtokens-update"></a>

Update single auth token by token.

```csharp
ziggeo.authtokens().update(string token_or_key, Dictionary<string, string> arguments)
```

 Arguments
- volatile: *Will this object automatically be deleted if it remains empty?*
- hidden: *If hidden, the token cannot be used directly.*
- expiration_date: *Expiration date for the auth token (Unix epoch time format)*
- usage_expiration_time: *Expiration time per session (seconds)*
- session_limit: *Maximal number of sessions*
- grants: *Permissions this tokens grants*

#### Delete<a name="method-authtokens-delete"></a>

Delete a single auth token by token.

```csharp
ziggeo.authtokens().delete(string token_or_key)
```

#### Create<a name="method-authtokens-create"></a>

Create a new auth token.

```csharp
ziggeo.authtokens().create(Dictionary<string, string> arguments)
```

 Arguments
- volatile: *Will this object automatically be deleted if it remains empty?*
- hidden: *If hidden, the token cannot be used directly.*
- expiration_date: *Expiration date for the auth token (Unix epoch time format)*
- usage_expiration_time: *Expiration time per session (seconds)*
- session_limit: *Maximal number of sessions*
- grants: *Permissions this tokens grants*

### Application<a name="method-application"></a>


The application token resource allows you to manage your application.

#### Get<a name="method-application-get"></a>

Read application.

```csharp
ziggeo.application().get()
```

#### Update<a name="method-application-update"></a>

Update application.

```csharp
ziggeo.application().update(Dictionary<string, string> arguments)
```

 Arguments
- volatile: *Will this object automatically be deleted if it remains empty?*
- name: *Name of the application*
- auth_token_required_for_create: *Require auth token for creating videos*
- auth_token_required_for_update: *Require auth token for updating videos*
- auth_token_required_for_read: *Require auth token for reading videos*
- auth_token_required_for_destroy: *Require auth token for deleting videos*
- client_can_index_videos: *Client is allowed to perform the index operation*
- client_cannot_access_unaccepted_videos: *Client cannot view unaccepted videos*
- enable_video_subpages: *Enable hosted video pages*

#### Get Stats<a name="method-application-get-stats"></a>

Read application stats

```csharp
ziggeo.application().get_stats(Dictionary<string, string> arguments)
```

 Arguments
- period: *Optional. Can be 'year' or 'month'.*

### Effect Profiles<a name="method-effect-profiles"></a>


The effect profiles resource allows you to access and create effect profiles for your app. Each effect profile may contain one process or more.

#### Create<a name="method-effect-profiles-create"></a>

Create a new effect profile.

```csharp
ziggeo.effectProfiles().create(Dictionary<string, string> arguments)
```

 Arguments
- key: *Effect profile key.*
- title: *Effect profile title.*
- default_effect: *Boolean. If TRUE, sets an effect profile as default. If FALSE, removes the default status for the given effect*

#### Index<a name="method-effect-profiles-index"></a>

Get list of effect profiles.

```csharp
ziggeo.effectProfiles().index(Dictionary<string, string> arguments)
```

 Arguments
- limit: *Limit the number of returned effect profiles. Can be set up to 100.*
- skip: *Skip the first [n] entries.*
- reverse: *Reverse the order in which effect profiles are returned.*

#### Get<a name="method-effect-profiles-get"></a>

Get a single effect profile

```csharp
ziggeo.effectProfiles().get(string token_or_key)
```

#### Delete<a name="method-effect-profiles-delete"></a>

Delete the effect profile

```csharp
ziggeo.effectProfiles().delete(string token_or_key)
```

#### Update<a name="method-effect-profiles-update"></a>

Updates an effect profile.

```csharp
ziggeo.effectProfiles().update(string token_or_key, Dictionary<string, string> arguments)
```

 Arguments
- default_effect: *Boolean. If TRUE, sets an effect profile as default. If FALSE, removes the default status for the given effect*

### Effect Profile Process<a name="method-effect-profile-process"></a>


The process resource allows you to directly access all process associated with a single effect profile.

#### Index<a name="method-effect-profile-process-index"></a>

Return all processes associated with a effect profile

```csharp
ziggeo.effectProfileProcess().index(string effect_token_or_key, Dictionary<string, string> arguments)
```

 Arguments
- states: *Filter streams by state*

#### Get<a name="method-effect-profile-process-get"></a>

Get a single process

```csharp
ziggeo.effectProfileProcess().get(string effect_token_or_key, string token_or_key)
```

#### Delete<a name="method-effect-profile-process-delete"></a>

Delete the process

```csharp
ziggeo.effectProfileProcess().delete(string effect_token_or_key, string token_or_key)
```

#### Create Filter Process<a name="method-effect-profile-process-create-filter-process"></a>

Create a new filter effect process

```csharp
ziggeo.effectProfileProcess().create_filter_process(string effect_token_or_key, Dictionary<string, string> arguments)
```

 Arguments
- effect: *Effect to be applied in the process*

#### Create Watermark Process<a name="method-effect-profile-process-create-watermark-process"></a>

Attaches an image to a new stream

```csharp
ziggeo.effectProfileProcess().create_watermark_process(string effect_token_or_key, Dictionary<string, string> arguments, string file)
```

 Arguments
- file: *Image file to be attached*
- vertical_position: *Specify the vertical position of your watermark (a value between 0.0 and 1.0)*
- horizontal_position: *Specify the horizontal position of your watermark (a value between 0.0 and 1.0)*
- video_scale: *Specify the image scale of your watermark (a value between 0.0 and 1.0)*

#### Edit Watermark Process<a name="method-effect-profile-process-edit-watermark-process"></a>

Edits an existing watermark process.

```csharp
ziggeo.effectProfileProcess().edit_watermark_process(string effect_token_or_key, string token_or_key, Dictionary<string, string> arguments, string file)
```

 Arguments
- file: *Image file to be attached*
- vertical_position: *Specify the vertical position of your watermark (a value between 0.0 and 1.0)*
- horizontal_position: *Specify the horizontal position of your watermark (a value between 0.0 and 1.0)*
- video_scale: *Specify the image scale of your watermark (a value between 0.0 and 1.0)*

### Meta Profiles<a name="method-meta-profiles"></a>


The meta profiles resource allows you to access and create meta profiles for your app. Each meta profile may contain one process or more.

#### Create<a name="method-meta-profiles-create"></a>

Create a new meta profile.

```csharp
ziggeo.metaProfiles().create(Dictionary<string, string> arguments)
```

 Arguments
- key: *Meta Profile profile key.*
- title: *Meta Profile profile title.*

#### Index<a name="method-meta-profiles-index"></a>

Get list of meta profiles.

```csharp
ziggeo.metaProfiles().index(Dictionary<string, string> arguments)
```

 Arguments
- limit: *Limit the number of returned meta profiles. Can be set up to 100.*
- skip: *Skip the first [n] entries.*
- reverse: *Reverse the order in which meta profiles are returned.*

#### Get<a name="method-meta-profiles-get"></a>

Get a single meta profile

```csharp
ziggeo.metaProfiles().get(string token_or_key)
```

#### Delete<a name="method-meta-profiles-delete"></a>

Delete the meta profile

```csharp
ziggeo.metaProfiles().delete(string token_or_key)
```

### Meta Profile Process<a name="method-meta-profile-process"></a>


The process resource allows you to directly access all process associated with a single meta profile.

#### Index<a name="method-meta-profile-process-index"></a>

Return all processes associated with a meta profile

```csharp
ziggeo.metaProfileProcess().index(string meta_token_or_key)
```

#### Get<a name="method-meta-profile-process-get"></a>

Get a single process

```csharp
ziggeo.metaProfileProcess().get(string meta_token_or_key, string token_or_key)
```

#### Delete<a name="method-meta-profile-process-delete"></a>

Delete the process

```csharp
ziggeo.metaProfileProcess().delete(string meta_token_or_key, string token_or_key)
```

#### Create Video Analysis Process<a name="method-meta-profile-process-create-video-analysis-process"></a>

Create a new video analysis meta process

```csharp
ziggeo.metaProfileProcess().create_video_analysis_process(string meta_token_or_key)
```

#### Create Audio Transcription Process<a name="method-meta-profile-process-create-audio-transcription-process"></a>

Create a new audio transcription meta process

```csharp
ziggeo.metaProfileProcess().create_audio_transcription_process(string meta_token_or_key)
```

#### Create Nsfw Process<a name="method-meta-profile-process-create-nsfw-process"></a>

Create a new nsfw filter meta process

```csharp
ziggeo.metaProfileProcess().create_nsfw_process(string meta_token_or_key, Dictionary<string, string> arguments)
```

 Arguments
- nsfw_action: *One of the following three: approve, reject, nothing.*

#### Create Profanity Process<a name="method-meta-profile-process-create-profanity-process"></a>

Create a new profanity filter meta process

```csharp
ziggeo.metaProfileProcess().create_profanity_process(string meta_token_or_key, Dictionary<string, string> arguments)
```

 Arguments
- profanity_action: *One of the following three: approve, reject, nothing.*

### Webhooks<a name="method-webhooks"></a>


The webhooks resource allows you to create or delete webhooks related to a given application.

#### Create<a name="method-webhooks-create"></a>

Create a new webhook for the given url to catch the given events.

```csharp
ziggeo.webhooks().create(Dictionary<string, string> arguments)
```

 Arguments
- target_url: *The url that will catch the events*
- encoding: *Data encoding to be used by the webhook to send the events.*
- events: *Comma-separated list of the events the webhook will catch. They must be valid webhook type events.*

#### Confirm<a name="method-webhooks-confirm"></a>

Confirm a webhook using its ID and the corresponding validation code.

```csharp
ziggeo.webhooks().confirm(Dictionary<string, string> arguments)
```

 Arguments
- webhook_id: *Webhook ID that's returned in the creation call.*
- validation_code: *Validation code that is sent to the webhook when created.*

#### Delete<a name="method-webhooks-delete"></a>

Delete a webhook using its URL.

```csharp
ziggeo.webhooks().delete(Dictionary<string, string> arguments)
```

 Arguments
- target_url: *The url that will catch the events*

### Analytics<a name="method-analytics"></a>


The analytics resource allows you to access the analytics for the given application

#### Get<a name="method-analytics-get"></a>

Get analytics for the given params

```csharp
ziggeo.analytics().get(Dictionary<string, string> arguments)
```

 Arguments
- from: *A UNIX timestamp in microseconds used as the start date of the query*
- to: *A UNIX timestamp in microseconds used as the end date of the query*
- date: *A UNIX timestamp in microseconds to retrieve data from a single date. If set, it overwrites the from and to params.*
- query: *The query you want to run. It can be one of the following: device_views_by_os, device_views_by_date, total_plays_by_country, full_plays_by_country, total_plays_by_hour, full_plays_by_hour, total_plays_by_browser, full_plays_by_browser*





## License <a name="license"></a>

Copyright (c) 2013-2022 Ziggeo
 
Apache 2.0 License
