#!/bin/sh

echo "This shell script helps test all direct demos within our /demos/ folder compiled as .exe files"
echo "Script will call some demos with its own pre-defined values."
echo "Your plan has to allow some of the functionality for you to be able to use it"
echo "\n"

app_token=APP_TOKEN
private_key=PRIVATE_KEY
encryption_key=ENCRYPTION_KEY
video_token=VIDEO_TOKEN
stream_token=STREAM_TOKEN
video_file=./assets/video1s.mp4
image_file=./assets/image.png
push_token=PUSH_SERVICE_TOKEN
tags=demos,test,tag_update,php
filter_from="1646089200000"
filter_to="1646521200000"
filter_date=""
filter_query="device_views_by_os"
effect_profile=EFFECT_PROFILE_TOKEN
meta_profile=META_PROFILE_TOKEN
auth_token=SERVER_AUTH_TOKEN
effect_filter=gray # can be: gray, cartoon, lucis, edge, chill, charcoal, sketch
url=https://ziggeo.com/
encoding=jsonheader
events=video_create,video_delete
webhook_id=some_id
validation_code=123456


# Colors
COLOR_GREEN='\033[0;32m' # Green
COLOR_RED='\033[0;31m' # Red
COLOR_END='\033[0m'    # No Color

# Copy the libraries into the demos folder to be able to run tests
cp ./lib/Newtonsoft.Json.dll ./demos/Newtonsoft.Json.dll
cp ./lib/Ziggeo.dll ./demos/Ziggeo.dll

#########
# Demos #
#########

count_demos=0
count_with_errors=0

now=$(date +"%T")
echo "\n\n****************************************************************************************" >> run_demos_log.log
echo "\nCurrent time : $now" >> run_demos_log.log
echo "\n****************************************************************************************" >> run_demos_log.log

run_demo()
{
	echo "\nRunning demo: $1"
	echo "\nmono $@"
	echo "\nmono $@" >> run_demos_log.log
	mono $@ >> run_demos_log.log
	result=$?
	count_demos=$((count_demos+1))

	if [ $result -ne 0 ]; then
		echo "\n${COLOR_RED}There was an error running${COLOR_END} $1"
		echo "\nThere was an error running $1" >> run_demos_log.log
		count_with_errors=$((count_with_errors+1))
		sleep 2
	else
		echo "${COLOR_GREEN}SUCCESS${COLOR_END}: The $1 finished without any errors"
		echo "SUCCESS: The $1 finished without any errors" >> run_demos_log.log
	fi

	sleep 2
}


# Videos
run_demo ./demos/videos_count.cs.exe $app_token $private_key
run_demo ./demos/videos_create.cs.exe $app_token $private_key $video_file
run_demo ./demos/videos_download_image.cs.exe $app_token $private_key $video_token $video_file download.jpg
run_demo ./demos/videos_download_video.cs.exe $app_token $private_key $video_token $video_file download.mp4
run_demo ./demos/videos_get.cs.exe $app_token $private_key $video_token
run_demo ./demos/videos_index.cs.exe $app_token $private_key
run_demo ./demos/videos_push_to_service.cs.exe $app_token $private_key $video_token $push_token
run_demo ./demos/videos_update.cs.exe $app_token $private_key $video_token $tags
#run_demo ./demos/videos_delete.cs.exe $app_token $private_key $video_token


# Streams
run_demo ./demos/streams_attach_image.cs.exe $app_token $private_key $video_token $stream_token $image_file
run_demo ./demos/streams_attach_video.cs.exe $app_token $private_key $video_token $stream_token $video_file
run_demo ./demos/streams_create.cs.exe $app_token $private_key $video_token $video_file


# Analytics


# Application
run_demo ./demos/application_get_stats.cs.exe $app_token $private_key


# Authtokens
run_demo ./demos/authtokens_create.cs.exe $app_token $private_key


# Effect Profiles
run_demo ./demos/effectprofiles_create.cs.exe $app_token $private_key effect_title effect_key
run_demo ./demos/effectprofiles_index.cs.exe $app_token $private_key


# Meta Profiles


# Webhook


# Permanent



# Cleanup - Remove the libraries from demo directory
rm ./demos/Newtonsoft.Json.dll
rm ./demos/Ziggeo.dll


echo "Done! We have gone through all $count_demos demos"

if [ $count_with_errors -ge 1 ]; then
	echo "\n$count_with_errors out of $count_demos finished with the error"
fi