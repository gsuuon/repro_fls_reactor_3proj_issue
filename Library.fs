namespace FlsTest

module Foo =
    type Bar =
        | Hey
        | Hi

module Say =
    let somefunction x = x + 2

    let hi () = "hi"

    let hello x name (y: Foo.Bar) =
        OtherProject.Say.hello "boo"

        match x with
        | 1 ->
            printfn "%s %s %A" (hi()) name y
        | _ ->
            printfn "%s %s" (Component.hey()) name
