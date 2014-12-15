let take = Seq.take
let each = Seq.iter
let takeWhile = Seq.takeWhile
let tail = Seq.skip 1
let zipWith = Seq.map2
let scan = Seq.scan

let a = seq {2..2..100}
printfn "Sequence: %A" a

printf "First 10 of sequence: "
each (fun x -> printf "%d " x) <| take 10 a
printfn ""
printf "< 50 in sequence: "
each (fun x -> printf "%d " x) <| takeWhile (fun x -> x<50) a
printfn ""
printfn "Tail of sequence: %A" <| tail a

let aDbl = zipWith (+) a a
printfn "a zipped with +a: %A" aDbl

(*
let rec fibs = seq {yield 1; yield 1; yield! zipWith (+) fibs (tail fibs)}
printf "Fibs: "
each (fun x -> printf "%d " x) <| take 10 fibs
printfn ""
*)

// Commented code above is not executed lazily enough; runs too slow - use scan instead
let rec fibs = seq { yield 1; yield! scan (+) 1 fibs }
printf "Fibs: "
each (fun x -> printf "%d " x) <| take 40 fibs
