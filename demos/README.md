This readme will show you how to run demos and how they are organized

# How to call demos through console

If you want to use the code from `videos_count.cs` you would want to open it and see what parameters it requires.

In its case this is important to us `args[0], args[1]`

It means that we need to pass `app_token` and `private_key` to our script.

## Before we can run them, we have to compile them.

To compile the script there is a very simple command that we would use.
* The process demonstrated here is for Linux based console, it will be slightly different if you use MS Visual Studio

```mcs -out:videos_count.exe -r:../lib/Ziggeo.dll -r:../lib/Newtonsoft.Json.dll videos_count.cs```

## We would do it like so:

```mono videos_count.exe APP_TOKEN PRIVATE_KEY```

So every file will have its own parameters, however they will always be called out like so:

```
mcs -out:file_name.exe -r:../lib/Ziggeo.dll -r:../lib/Newtonsoft.Json.dll videos_count.cs
mono file_name.exe parameter1 parameter2
```

# Organization

The demos are organized by the class and function name. So for example if you want to see how to get the count of the videos you would find it in the name that matches the same:
 1. videos()
 2. count()

...making the filename "videos_count.cs"

The scripts that are created to help with different things like benchmarks (_benchmark.cs) and alike, are prefixed with an underscore and then match the similar structure as above to help you separate it all (however they can have any filename that describes action or multiple actions).