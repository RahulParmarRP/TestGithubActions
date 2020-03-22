#!/bin/sh -l

set -e

if [[ -z "$PROJECT_CSPROJ_FILE_PATH" ]]; then
	echo "Set the PROJECT_CSPROJ_FILE_PATH env variable." ;
	exit 1 ;
fi

if [[ -z "$PROJECT_DIRECTORY_PATH" ]]; then
	echo "Set the PROJECT_DIRECTORY_PATH env variable." ;
	exit 1 ;
fi