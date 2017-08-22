using System.Threading.Tasks;
using Grpc.Core;
using static Shared.GeneratedCode.HugePayloadService;
using System.Collections.Generic;

namespace GrpcServer
{
    public class HugePayloadServiceImplementation : HugePayloadServiceBase
    {
        public override Task<HugeResponse> SendHugePayload(HugeRequest request, ServerCallContext context)
        {
            return Task.FromResult(new HugeResponse
            {
                 IntList = {  CreateIntList()  },
                 StringList = { CreateStringList() }                
            });
        }

        public static List<int> CreateIntList()
        {
            var intList = new List<int>();
            for (int i = 0; i < 150; i++)
                intList.Add(123);

            return intList;
        }

        public static List<string> CreateStringList()
        {
            var stringList = new List<string>();
            for (int i = 0; i < 150; i++)
                stringList.Add(new string('a', 25));

            return stringList;
        }
    }
}
