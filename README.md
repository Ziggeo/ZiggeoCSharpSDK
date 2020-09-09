# Ziggeo's C# Server SDK

latest version: **0.1.20**

## Index

1. [Why Ziggeo's C# Server Side SDK?](#why-us)
2. [Prerequisites](#prerequisites)
    1. [Download](#download)
    2. [How to use](#how-to-use)

    3[Dependencies](#dependencies)3. [Client-Side Integration](#codes-client-side)
4. [Server-Side Integration](#codes-server-side)
    1. [Init](#codes-init)
    2. [Available Methods](#codes-methods)
    3. [Methods for Videos](#method-videos)
        1. [Videos Ziggeo.videos](#method-videos-ziggeo.videos)
        2. [Videos Ziggeo.videos](#method-videos-ziggeo.videos)
        3. [Videos Ziggeo.videos](#method-videos-ziggeo.videos)
        4. [Videos Ziggeo.videos](#method-videos-ziggeo.videos)
        5. [Videos Ziggeo.videos](#method-videos-ziggeo.videos)
        6. [Videos Ziggeo.videos](#method-videos-ziggeo.videos)
        7. [Videos Ziggeo.videos](#method-videos-ziggeo.videos)
        8. [Videos Ziggeo.videos](#method-videos-ziggeo.videos)
        9. [Videos Ziggeo.videos](#method-videos-ziggeo.videos)
        10. [Videos Ziggeo.videos](#method-videos-ziggeo.videos)
        11. [Videos Ziggeo.videos](#method-videos-ziggeo.videos)
        12. [Videos Ziggeo.videos](#method-videos-ziggeo.videos)
        13. [Videos Ziggeo.videos](#method-videos-ziggeo.videos)
        14. [Videos Ziggeo.videos](#method-videos-ziggeo.videos)
        15. [Videos Ziggeo.videos](#method-videos-ziggeo.videos)
        16. [Videos Ziggeo.videos](#method-videos-ziggeo.videos)
    4. [Methods for Streams](#method-streams)
        1. [Streams Ziggeo.streams](#method-streams-ziggeo.streams)
        2. [Streams Ziggeo.streams](#method-streams-ziggeo.streams)
        3. [Streams Ziggeo.streams](#method-streams-ziggeo.streams)
        4. [Streams Ziggeo.streams](#method-streams-ziggeo.streams)
        5. [Streams Ziggeo.streams](#method-streams-ziggeo.streams)
        6. [Streams Ziggeo.streams](#method-streams-ziggeo.streams)
        7. [Streams Ziggeo.streams](#method-streams-ziggeo.streams)
        8. [Streams Ziggeo.streams](#method-streams-ziggeo.streams)
        9. [Streams Ziggeo.streams](#method-streams-ziggeo.streams)
        10. [Streams Ziggeo.streams](#method-streams-ziggeo.streams)
        11. [Streams Ziggeo.streams](#method-streams-ziggeo.streams)
    5. [Methods for Authtokens](#method-authtokens)
        1. [Authtokens Ziggeo.authtokens](#method-authtokens-ziggeo.authtokens)
        2. [Authtokens Ziggeo.authtokens](#method-authtokens-ziggeo.authtokens)
        3. [Authtokens Ziggeo.authtokens](#method-authtokens-ziggeo.authtokens)
        4. [Authtokens Ziggeo.authtokens](#method-authtokens-ziggeo.authtokens)
    6. [Methods for Application](#method-application)
        1. [Application Ziggeo.application](#method-application-ziggeo.application)
        2. [Application Ziggeo.application](#method-application-ziggeo.application)
        3. [Application Ziggeo.application](#method-application-ziggeo.application)
    7. [Methods for Effect Profiles](#method-effect-profiles)
        1. [Effect Profiles Ziggeo.effectProfiles](#method-effect-profiles-ziggeo.effectprofiles)
        2. [Effect Profiles Ziggeo.effectProfiles](#method-effect-profiles-ziggeo.effectprofiles)
        3. [Effect Profiles Ziggeo.effectProfiles](#method-effect-profiles-ziggeo.effectprofiles)
        4. [Effect Profiles Ziggeo.effectProfiles](#method-effect-profiles-ziggeo.effectprofiles)
        5. [Effect Profiles Ziggeo.effectProfiles](#method-effect-profiles-ziggeo.effectprofiles)
    8. [Methods for Effect Profile Process](#method-effect-profile-process)
        1. [Effect Profile Process Ziggeo.effectProfileProcess](#method-effect-profile-process-ziggeo.effectprofileprocess)
        2. [Effect Profile Process Ziggeo.effectProfileProcess](#method-effect-profile-process-ziggeo.effectprofileprocess)
        3. [Effect Profile Process Ziggeo.effectProfileProcess](#method-effect-profile-process-ziggeo.effectprofileprocess)
        4. [Effect Profile Process Ziggeo.effectProfileProcess](#method-effect-profile-process-ziggeo.effectprofileprocess)
        5. [Effect Profile Process Ziggeo.effectProfileProcess](#method-effect-profile-process-ziggeo.effectprofileprocess)
        6. [Effect Profile Process Ziggeo.effectProfileProcess](#method-effect-profile-process-ziggeo.effectprofileprocess)
    9. [Methods for Meta Profiles](#method-meta-profiles)
        1. [Meta Profiles Ziggeo.metaProfiles](#method-meta-profiles-ziggeo.metaprofiles)
        2. [Meta Profiles Ziggeo.metaProfiles](#method-meta-profiles-ziggeo.metaprofiles)
        3. [Meta Profiles Ziggeo.metaProfiles](#method-meta-profiles-ziggeo.metaprofiles)
        4. [Meta Profiles Ziggeo.metaProfiles](#method-meta-profiles-ziggeo.metaprofiles)
    10. [Methods for Meta Profile Process](#method-meta-profile-process)
        1. [Meta Profile Process Ziggeo.metaProfileProcess](#method-meta-profile-process-ziggeo.metaprofileprocess)
        2. [Meta Profile Process Ziggeo.metaProfileProcess](#method-meta-profile-process-ziggeo.metaprofileprocess)
        3. [Meta Profile Process Ziggeo.metaProfileProcess](#method-meta-profile-process-ziggeo.metaprofileprocess)
        4. [Meta Profile Process Ziggeo.metaProfileProcess](#method-meta-profile-process-ziggeo.metaprofileprocess)
        5. [Meta Profile Process Ziggeo.metaProfileProcess](#method-meta-profile-process-ziggeo.metaprofileprocess)
        6. [Meta Profile Process Ziggeo.metaProfileProcess](#method-meta-profile-process-ziggeo.metaprofileprocess)
    11. [Methods for Webhooks](#method-webhooks)
        1. [Webhooks Ziggeo.webhooks](#method-webhooks-ziggeo.webhooks)
        2. [Webhooks Ziggeo.webhooks](#method-webhooks-ziggeo.webhooks)
        3. [Webhooks Ziggeo.webhooks](#method-webhooks-ziggeo.webhooks)
    12. [Methods for Analytics](#method-analytics)
        1. [Analytics Ziggeo.analytics](#method-analytics-ziggeo.analytics)
6. [License](#license)


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

1.Videos
1.Streams
1.Authtokens
1.Application
1.Effect Profiles
1.Effect Profile Process
1.Meta Profiles
1.Meta Profile Process
1.Webhooks
1.Analytics

Each of this sections has their own actions and they are explained bellow



### Videos<a name="method-videos"></a>


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
- expire_on: *On which date will this video be deleted. String in ISO 8601 format: YYYY-MM-DD*

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
- expire_on: *On which date will this video be deleted. String in ISO 8601 format: YYYY-MM-DD*

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

### Streams<a name="method-streams"></a>


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

#### Attach Subtitle

Attaches a subtitle to the stream.

```csharp
ziggeo.streams().attach_subtitle(string video_token_or_key, string token_or_key, Dictionary<string, string> arguments)
```

 Arguments
- lang: *Subtitle language*
- label: *Subtitle reference*
- data: *Actual subtitle*

#### Bind

Closes and submits the stream

```csharp
ziggeo.streams().bind(string video_token_or_key, string token_or_key, Dictionary<string, string> arguments)
```

 Arguments

### Authtokens<a name="method-authtokens"></a>


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
- expiration_date: *Expiration date for the auth token (Unix epoch time format)*
- usage_expiration_time: *Expiration time per session (seconds)*
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
- expiration_date: *Expiration date for the auth token (Unix epoch time format)*
- usage_expiration_time: *Expiration time per session (seconds)*
- session_limit: *Maximal number of sessions*
- grants: *Permissions this tokens grants*

### Application<a name="method-application"></a>


The application token resource allows you to manage your application.

#### Get

Read application.

```csharp
ziggeo.application().get()
```

#### Update

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

#### Get Stats

Read application stats

```csharp
ziggeo.application().get_stats(Dictionary<string, string> arguments)
```

 Arguments
- period: *Optional. Can be 'year' or 'month'.*

### Effect Profiles<a name="method-effect-profiles"></a>


The effect profiles resource allows you to access and create effect profiles for your app. Each effect profile may contain one process or more.

#### Create

Create a new effect profile.

```csharp
ziggeo.effectProfiles().create(Dictionary<string, string> arguments)
```

 Arguments
- key: *Effect profile key.*
- title: *Effect profile title.*
- default_effect: *Boolean. If TRUE, sets an effect profile as default. If FALSE, removes the default status for the given effect*

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

#### Update

Updates an effect profile.

```csharp
ziggeo.effectProfiles().update(string token_or_key, Dictionary<string, string> arguments)
```

 Arguments
- default_effect: *Boolean. If TRUE, sets an effect profile as default. If FALSE, removes the default status for the given effect*

### Effect Profile Process<a name="method-effect-profile-process"></a>


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
- vertical_position: *Specify the vertical position of your watermark (a value between 0.0 and 1.0)*
- horizontal_position: *Specify the horizontal position of your watermark (a value between 0.0 and 1.0)*
- video_scale: *Specify the image scale of your watermark (a value between 0.0 and 1.0)*

#### Edit Watermark Process

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

### Meta Profile Process<a name="method-meta-profile-process"></a>


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

### Webhooks<a name="method-webhooks"></a>


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

#### Confirm

Confirm a webhook using its ID and the corresponding validation code.

```csharp
ziggeo.webhooks().confirm(Dictionary<string, string> arguments)
```

 Arguments
- webhook_id: *Webhook ID that's returned in the creation call.*
- validation_code: *Validation code that is sent to the webhook when created.*

#### Delete

Delete a webhook using its URL.

```csharp
ziggeo.webhooks().delete(Dictionary<string, string> arguments)
```

 Arguments
- target_url: *The url that will catch the events*

### Analytics<a name="method-analytics"></a>


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





## License <a name="license"></a>

Copyright (c) 2013-2020 Ziggeo
 
Apache 2.0 License
