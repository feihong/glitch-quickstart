package main

import (
    "fmt"
    "log"
    "net/http"
)

func main() {

    http.HandleFunc("/", func(w http.ResponseWriter, r *http.Request){
        fmt.Fprintf(w, "Hello from Go, 你好")
    })

    log.Fatal(http.ListenAndServe(":3000", nil))

}
