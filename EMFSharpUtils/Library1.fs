module EMFSharpUtils

let rec nthFibonacci x =
    match x with
    | 0 -> 0
    | 1 -> 1
    | _ -> x + nthFibonacci (x-1)
