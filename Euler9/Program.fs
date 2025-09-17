let checkPythogoreanTriple (a: int, b: int, c: int) = a * a + b * b = c * c

let findTriplet () =
    seq {
        for a in { 1..1000 } do
            for b in { a..1000 } do
                let c = 1000 - a - b

                if a < b && b < c && checkPythogoreanTriple (a, b, c) = true then
                    yield a, b, c
    }
    |> Seq.tryHead

match findTriplet () with
| Some(a, b, c) ->
    printfn $"Pythagorean triplet: {a} {b} {c}"
    printfn $"Product: {a * b * c}"
| None -> printfn "No triplet found"
