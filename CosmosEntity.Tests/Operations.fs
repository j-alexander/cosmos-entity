module CosmosEntity.Tests.Operations

open NUnit.Framework

[<SetUp>]
let Setup () =
    ()

[<Test>]
let Test1 () =
    let x = CosmosEntity.Tests.Secrets.cosmosDB
    Assert.Pass()