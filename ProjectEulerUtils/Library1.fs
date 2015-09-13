namespace ProjectEuler

open System.Collections.Generic;

module PEUtils =

    let fibSeq =
        let rec fibSeq n1 n2 =
            seq { let n0 = n1 + n2 
                  yield n0
                  yield! fibSeq n0 n1 }
        seq { yield 1 ; yield 1 ; yield! (fibSeq 1 1) }

    let firstNFibs x =
        fibSeq |> Seq.take x

    let rec nthFib x =
        match x with
        | 0 -> 1
        | 1 -> 1
        | _ -> nthFib (x-1) + nthFib (x-2)