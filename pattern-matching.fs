let length = List.length
let join = List.concat

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

let list_matching list =
  match list with
    | [] -> "empty list"
    | [a] -> "list with one element"
    | [a;_] -> "list with two elements"
    | _ -> "list with several elements"

let head_tail_matching list =
  match list with
    | [] -> "empty list"
    | [_] -> "list with one element"
    | _::tail -> sprintf "list of length %d" <| (length tail + 1)

printfn "%s" <| fun1 "asdasdlkjlkj"
printfn "%s" <| fun2 ("foo")

printfn "%s" <| list_matching [1;2;3]
printfn "%s" <| list_matching [1;2]
printfn "%s" <| list_matching [1]
printfn "%s" <| list_matching []

printfn "%s" <| head_tail_matching [1;2;3]
printfn "%s" <| head_tail_matching [1]
printfn "%s" <| head_tail_matching []
