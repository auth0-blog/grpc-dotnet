using System;
using System.Threading.Tasks;
using CreditRatingService;
using Grpc.Net.Client;

namespace GrpcGreeterClient
{
    class Program
    {
        // Comment the following method if you are running on MacOS
        static async Task Main(string[] args)
        {
            // The port number(5001) must match the port of the gRPC server.
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client =  new CreditRatingCheck.CreditRatingCheckClient(channel);
            var creditRequest = new CreditRequest { CustomerId = "id0201", Credit = 7000};
            var reply = await client.CheckCreditRequestAsync(creditRequest);

            Console.WriteLine($"Credit for customer {creditRequest.CustomerId} {(reply.IsAccepted ? "approved" : "rejected")}!");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        // Uncomment the following method if you are running on MacOS
        // static async Task Main(string[] args)
        // {
        //     // The following statement allows you to call insecure services. To be used only in development environments.
        //     AppContext.SetSwitch(
        //         "System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);

        //     // The port number(5001) must match the port of the gRPC server.
        //     var channel = GrpcChannel.ForAddress("http://localhost:5000");
        //     var client =  new CreditRatingCheck.CreditRatingCheckClient(channel);
        //     var creditRequest = new CreditRequest { CustomerId = "id0201", Credit = 7000};
        //     var reply = await client.CheckCreditRequestAsync(creditRequest);

        //     Console.WriteLine($"Credit for customer {creditRequest.CustomerId} {(reply.IsAccepted ? "approved" : "rejected")}!");
        //     Console.WriteLine("Press any key to exit...");
        //     Console.ReadKey();
        // }
    }
}
