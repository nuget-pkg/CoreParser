#! /usr/bin/env bash
set -uvx
set -e
cd "$(dirname "$0")"
cwd=`pwd`
ts=`date "+%Y.%m%d.%H%M.%S"`
cd CoreParser.Demo
dotnet run --project CoreParser.Demo.csproj --framework net10.0 "$@"
