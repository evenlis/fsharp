let fun1 a =
  match a with
    | "foo" -> "bar"
    | "answer" -> "42"
    | _ -> "No match"

let fun2 =
  function
    | "foo" -> "bar"
    | "answer" -> "42"
    | _ -> "No match"

printfn "%s" <| fun1 "asdasdlkjlkj"
printfn "%s" <| fun2 ("foo")
