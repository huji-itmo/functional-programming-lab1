module Tests

open Xunit
open Program

[<Fact>]
let ``Test from task description`` () =
    Assert.True(isAmicablePair (220, 284))
    Assert.False(isAmicablePair (220, 220))

[<Fact>]
let ``Divisors of 1 returns 1`` () =
    let expected = [ 1 ]
    let actual = getDivisors 1 |> Seq.sort |> Seq.toList
    Assert.Equal<int list>(expected, actual)

[<Fact>]
let ``Divisors of prime number 17 returns only 1`` () =
    let expected = [ 1 ]
    let actual = getDivisors 17 |> Seq.sort |> Seq.toList
    Assert.Equal<int list>(expected, actual)

[<Fact>]
let ``Divisors of 4 returns 1 and 2`` () =
    let expected = [ 1; 2 ]
    let actual = getDivisors 4 |> Seq.sort |> Seq.toList
    Assert.Equal<int list>(expected, actual)

[<Fact>]
let ``Divisors of 6 returns 1, 2, and 3`` () =
    let expected = [ 1; 2; 3 ]
    let actual = getDivisors 6 |> Seq.sort |> Seq.toList
    Assert.Equal<int list>(expected, actual)

[<Fact>]
let ``Divisors of 9 returns 1 and 3`` () =
    let expected = [ 1; 3 ]
    let actual = getDivisors 9 |> Seq.sort |> Seq.toList
    Assert.Equal<int list>(expected, actual)

[<Fact>]
let ``Divisors of 12 returns 1, 2, 3, 4, and 6`` () =
    let expected = [ 1; 2; 3; 4; 6 ]
    let actual = getDivisors 12 |> Seq.sort |> Seq.toList
    Assert.Equal<int list>(expected, actual)

[<Fact>]
let ``Divisors of 16 returns 1, 2, 4, and 8`` () =
    let expected = [ 1; 2; 4; 8 ]
    let actual = getDivisors 16 |> Seq.sort |> Seq.toList
    Assert.Equal<int list>(expected, actual)
