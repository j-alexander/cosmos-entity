module CosmosEntity.Tests.Secrets

open Microsoft.Extensions.Configuration

let private configuration =
    let builder = new ConfigurationBuilder()
    builder.AddUserSecrets("4a903f18-4887-430c-8b1d-01bcdff11a80", true).Build()

let cosmosDB = configuration.["CosmosDB"]
