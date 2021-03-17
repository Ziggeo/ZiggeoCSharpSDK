This Demo App includes 2 parts (MVC app with front-end interaction and Testing part), also could be added additional 3rd option via API URLs.

*1st* please rename `Config.cs.example` file with just `Config.cs` and make required changed inside of the file by adding your application tokens.
After You can run application where you can find SDK examples related : 
- Videos *(When you try to create video, uploaded file has to be in the root directory, for real examples you have to manage it by yourself)*
- Profiles

In Test for now you can find SDK examples related:
- Analytics
- Application
- Auth
- MetaProfiles

If you plan upload big files using this example, you can manage file-size from `web.config` file in `maxAllowedContentLength="LIMIT_IN_BYTES"`
***Note***: *maxRequestLength* is in kilobytes & *maxAllowedContentLength* is in Bytes
