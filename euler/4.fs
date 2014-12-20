let reverse = Array.rev
let filter = List.filter
let append = List.append
let maximum = List.max
let map = List.map
let head = List.head
let products = [for x in [999..-1..100] do for y in [999..-1..100] -> x*y]
let isPalindrome (s:string) =
  let arr = s.ToCharArray()
  arr = reverse arr

printfn "%i" <| maximum (map (int) (filter isPalindrome (map (fun x -> sprintf "%i" x) products)))
