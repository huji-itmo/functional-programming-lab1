open System.Diagnostics

let getDivisors (num: int) =
    if num = 1 then
        seq { }
    else
        assert (num >= 1)

        let upper_bound = num |> float |> sqrt |> ceil |> int

        seq {
            yield 1

            for divisor in { 2..upper_bound } do
                if num % divisor = 0 then
                    yield divisor
                    let divisor2 = num / divisor

                    if divisor <> divisor2 && divisor2 <> num then
                        yield divisor2
        }

let d (a: int) = getDivisors a |> Seq.sum

let isAmicablePair (a: int, b: int) = a <> b && d a = b && d b = a

let getPrecomputedDValues upper_bound = [ 1..upper_bound ] |> List.map d

let amicableNumbers upper_bound =
    let precomputedDValues = getPrecomputedDValues upper_bound

    seq {
        for a in 1..upper_bound do
            for b in a..upper_bound do
                if precomputedDValues[a - 1] = b && precomputedDValues[b - 1] = a then
                    yield a
                    yield b
    }

let sum upper_bound = amicableNumbers upper_bound |> Seq.sum

let stopwatch = Stopwatch.StartNew()
let result = sum 10000
stopwatch.Stop()

printfn $"Sum of all the amicable numbers under 10000 is {result}"
printfn $"Execution Time: {stopwatch.ElapsedMilliseconds} ms"
