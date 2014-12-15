let map = Array.map
let filter = Array.filter
let dbl x = x*2
let inc x = x+1

printfn "Manual: %A" [|1;2;3;4;5|]
printfn "Comprehension: %A" [|1..5|]
printfn "For-loop comprehension: %A" [|for i in 1..5 -> i|]

let zeroArr : int array = Array.zeroCreate 5
printfn "Array.zeroCreate: %A" zeroArr

let arr = [|1..10|]
printfn "Slicing: %A" arr.[..4]
printfn "Function mapping: %A" <| map dbl arr
printfn "Function mapping: %A" <| map inc arr
printfn "Composite function mapping; (x+1)*2: %A" <| map (dbl << inc) arr
printfn "Filter even numbers: %A" <| filter (fun x -> x%2=0) arr
printfn "Map dbl and filter even numbers: %A" <| filter (fun x -> x%2=0)  (map dbl arr)
printfn "Map composite - (x+1)*2 - and filter even numbers: %A" <| filter (fun x -> x%2=0) (map (dbl << inc) arr)
