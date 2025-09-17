module Tests

open System
open Xunit
open Program

[<Fact>]
let ``Test triple`` () =
    Assert.True(checkPythogoreanTriple (3, 4, 5))
    Assert.False(checkPythogoreanTriple (2, 4, 5))

let ``Test finding triple`` =
    let result = findTriplet ()

    Assert.True result.IsSome

    Assert.Equal((200, 375, 425), result.Value)
