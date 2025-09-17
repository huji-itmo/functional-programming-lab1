module Tests

open System
open Xunit
open Program

[<Fact>]
let ``Test from task description`` () =
    Assert.True(isAmicablePair (220, 284))
    Assert.False(isAmicablePair (220, 220))
