echo "Versions as of $(date)"

uname -a
echo "Dotnet: $(dotnet --version)"
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
echo "Sqlite: $(sqlite3 -version)"
swift -version
