open System
open Suave

let html =
  [ yield "<html><head><meta charset=\"utf-8\"><title>Hello</title></head>"
    yield "<body>"
    yield "<h1>Hello from F#</h1>"
    yield "你好世界！"
    yield "</body></html>"
  ] |> String.concat "\n"

let config =
  { defaultConfig with
      bindings = [ HttpBinding.createSimple HTTP "127.0.0.1" 3000 ]
  }

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    startWebServer config (Successful.OK html)
    0 // return an integer exit code
