This repository contains two .NET Core projects implementing a service application (`CreditRatingService`) and a client (`CreditRatingClient`) communicating via gRPC.

The following article describes the implementation details: [Implementing Microservices with gRPC and .NET Core 3.0](https://auth0.com/blog/implementing-microservices-grpc-dotnet-core-3/)

## To run the applications:

Clone the repo: `git clone https://github.com/auth0-blog/grpc-dotnet.git`

To run the `CreditRatingService` application:

1. Move to the `CreditRatingService` folder 
2. Type `dotnet run` in a terminal window

> **NOTE:** If you are using MacOS, you need to disable TLS support. Follow the instructions in `Program.cs`
>
> Read the article for more details



To run the `CreditRatingClient` application:

1. Move to the `CreditRatingClient` folder 
2. Type `dotnet run` in a terminal window

> **NOTE:** If you are using MacOS, you need to disable TLS support. Follow the instructions in `Program.cs`
>
> Read the article for more details

## Requirements:

- [.NET Core 3.0](https://dotnet.microsoft.com/download/dotnet-core/3.0) installed on your machine

  
