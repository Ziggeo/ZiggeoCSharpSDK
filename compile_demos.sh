#!/bin/sh

echo "This shell script helps compile all demos into .exe files. They will be placed within the demos folder as well"

counter=0
demos_count=0

for file in ./demos/*.cs
do
	mcs -out:"$file.exe" -r:./lib/Ziggeo.dll -r:./lib/Newtonsoft.Json.dll $file

	result=$?
	demos_count=$((demos_count+1))

	if [ $result -eq 0 ]; then
		echo "$file.exe created"
	else
		echo "Unable to create $file.exe due to errors"
		counter=$((counter+1))
	fi

done

if [ $counter -eq 0 ]; then
	echo "All ($demos_count) demos were compiled successfully."
else
	echo "$counter out of $demos_count demos failed to compile to exe files"
fi