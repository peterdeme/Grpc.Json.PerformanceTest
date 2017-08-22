using Grpc.Core;
using Shared.GeneratedCode;
using System;

namespace GrpcServer
{
    class Program
    {
        const string Host = "0.0.0.0";
        const int Port = 23456;

        static void Main(string[] args)
        {
            Server server = new Server
            {
                Services = {
                    SmallPayloadService.BindService(new SmallPayloadImplementation()),
                    HugePayloadService.BindService(new HugePayloadServiceImplementation())
                },
                Ports = { { Host, Port, ServerCredentials.Insecure } }
            };
            server.Start();

            Console.WriteLine("Press any key to stop the server...");
            Console.ReadKey();

            server.ShutdownAsync().Wait();
        }
    }
}