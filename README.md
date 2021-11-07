# Feihong's Glitch quickstart

Reference project: https://glitch.com/edit/#!/silk-mini-saltasaurus

## Actions

Open terminal: In sidebar, select Tools > Terminal.

Show memory and disk usage: In sidebar, select App Status.

## Commands

Refresh editor to display files created from command line:

    refresh

Get the versions of interesting tools (see versions.txt for results from latest run):

    source versions.sh

## Go

To build:

    go build

Clean build takes 15s, subsequent builds take 1s. Memory use is 11 MB.

To run, change scripts/start to `./app`.

## F#

To build:

    dotnet build

Clean build takes 47s, subsequent builds take 13s. Memory use is 49 MB.

To run, change scripts/start to `dotnet run`.

## Notes

I can compile and run simple Erlang programs.

The stock Fastify app uses 24 MB of memory.

Some other notable tools whose versions I don't care about:

- apl
- perl
- php
