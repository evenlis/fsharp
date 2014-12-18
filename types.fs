type ProgrammingLanguage =
  | Haskell = 1
  | FSharp = 2
  | Python = 3

let fav : ProgrammingLanguage = ProgrammingLanguage.Haskell
let lang : ProgrammingLanguage = ProgrammingLanguage.Haskell
printfn "%b" <| (fav = lang)

let division_and_remainder a b =
  let x = a/b
  let y = a%b
  (x,y)
printfn "Result: %d, Remainder: %d" <|| (division_and_remainder 19 4)

type GeometricalComponent =
  | Point of int * int
  | EquilateralTriangle of double
  | Square of double
  | Circle of double

let area shape =
  match shape with
    | Point _ -> 0.0
    | EquilateralTriangle side -> (sqrt 3.0) / 4.0 * side * side
    | Square side -> side*side
    | Circle radius -> 3.14159265359 * radius * radius

let sq = Square(5.7)
let tri = EquilateralTriangle(4.3)
let cir = Circle(5.4)

printfn "Area of square: %f" <| area sq
printfn "Area of triangle: %f" <| area tri
printfn "Area of circle: %f" <| area cir

let validInt = Some 1
let invalidInt = None

match validInt with
  | Some x -> printfn "Value: %d" x
  | None -> printfn "No value"
