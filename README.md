# Feihong's Glitch quickstart

## Actions

Open terminal. In sidebar, select Tools > Terminal.

Show memory and disk usage. In sidebar, select App Status.

## Commands

Refresh editor to display files created from command line:

    refresh

Get the versions of interesting tools

```
uname -a
echo "Dotnet: $(dotnet --version)
elixir --version
erl -noshell -eval 'erlang:display(erlang:system_info(system_version))' -eval 'init:stop()'
go version
ghc --version
javac -version
lua -v
ocaml -version
echo "Pony: $(ponyc --version)"
python3 --version
ruby --version
rustc --version
swift -version
```

Result as of November 6, 2021:

```
Linux 8c587e8c8c5d 4.4.0-1128-aws #142-Ubuntu SMP Fri Apr 16 12:42:33 UTC 2021 x86_64 x86_64 x86_64 GNU/Linux
Dotnet: 2.1.818
Erlang/OTP 24 [erts-12.1] [source] [64-bit] [smp:4:1] [ds:4:1:10] [async-threads:1]

Elixir 1.12.2 (compiled with Erlang/OTP 22)
"Erlang/OTP 24 [erts-12.1] [source] [64-bit] [smp:4:1] [ds:4:1:10] [async-threads:1]\n"
go version go1.11.2 linux/amd64
The Glorious Glasgow Haskell Compilation System, version 7.10.3
javac 1.8.0_292
Lua 5.2.4  Copyright (C) 1994-2015 Lua.org, PUC-Rio
The OCaml toplevel, version 4.02.3
Pony: 0.24.4 [release]
compiled with: llvm 3.9.1 -- cc (Ubuntu 5.4.0-6ubuntu1~16.04.10) 5.4.0 20160609
Defaults: pic=false ssl=openssl_0.9.0
Python 3.7.10
ruby 2.5.8p224 (2020-03-31 revision 67882) [x86_64-linux-gnu]
rustc 1.32.0 (9fda7c223 2019-01-16)
Swift version 5.1 (swift-5.1-RELEASE)
Target: x86_64-unknown-linux-gnu
```

## Notes

Running and compiling simple Go and Erlang programs works. 

I successfully build and ran simple web servers using these languages:

- Go
- F#

Running `go build` on a minimal project takes about 1 second. Memory use is 14 MB (out of 512 MB).

Running `dotnet build` on a minimal project takes about 33 seconds from a clean build (14 seconds from cached build). Memory use is 54 MB.

Some other notable tools whose versions I don't care about:

- apl
- perl
- php
