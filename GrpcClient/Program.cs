using Grpc.Core;
using Shared.GeneratedCode;
using System.Collections.Generic;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace GrpcClient
{
    public class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<BenchmarkClass>();
        }

    }

    public class BenchmarkClass
    {
        private static readonly HugePayloadService.HugePayloadServiceClient _hugePayloadClient;
        private static readonly SmallPayloadService.SmallPayloadServiceClient _smallPayloadClient;

        static BenchmarkClass()
        {
            Channel channel = new Channel("127.0.0.1:23456", ChannelCredentials.Insecure);

            _hugePayloadClient = new HugePayloadService.HugePayloadServiceClient(channel);

            _smallPayloadClient = new SmallPayloadService.SmallPayloadServiceClient(channel);
        }


        [Benchmark]
        public static async Task SendHugeRequestToServer()
        {
            await _hugePayloadClient.SendHugePayloadAsync(new HugeRequest { IntList = { CreateIntList() }, StringList = { CreateStringList() } });
        }

        [Benchmark]
        public static async Task SendSmallRequestToServer()
        {
            await _smallPayloadClient.SendSmallPayloadAsync(new SmallRequest { Message = "SmallRequest" });
        }

        private static List<int> CreateIntList()
        {
            var intList = new List<int>();
            for (int i = 0; i < 150; i++)
                intList.Add(123);

            return intList;
        }

        private static List<string> CreateStringList()
        {
            var stringList = new List<string>();
            for (int i = 0; i < 150; i++)
                stringList.Add(new string('a', 25));

            return stringList;
        }
    }
}