# Feihong's Glitch quickstart

Reference project: https://glitch.com/edit/#!/silk-mini-saltasaurus

## Actions

Open terminal. In sidebar, select Tools > Terminal.

Show memory and disk usage. In sidebar, select App Status.

## Commands

Refresh editor to display files created from command line:

    refresh

Get the versions of interesting tools:

    source versions.sh

## Notes

Running and compiling simple Go and Erlang programs works.

I successfully built and ran simple web servers using these languages:

- Go
- F#

Running `go build` on a minimal project takes about 1 second. Memory use is 14 MB (out of 512 MB). This compared to the stock Fastify app which uses 53 MB.

Running `dotnet build` on a minimal project takes about 33 seconds from a clean build (14 seconds from cached build). Memory use is 54 MB.

Some other notable tools whose versions I don't care about:

- apl
- perl
- php
