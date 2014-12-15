let add x = x + 1
let dbl x = x * 2

printfn "5+1: %d" <| add 5
printfn "5*2: %d" <| dbl 5
printfn "(5+1)*2: %d" <| (add >> dbl) 5
printfn "(5*2)+1: %d" <| (add << dbl) 5
