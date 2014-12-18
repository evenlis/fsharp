let scan = Seq.scan
let each = Seq.iter
let takeWhile = Seq.takeWhile
let filter = Seq.filter
let sum = Seq.sum
let rec fibs = seq {yield 1; yield! scan (+) 1 fibs}

printfn "Sum: %d" <| sum (filter (fun x -> x % 2 = 0) (takeWhile (fun x -> x<=4000000) fibs))
