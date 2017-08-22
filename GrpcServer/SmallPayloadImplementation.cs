using System.Threading.Tasks;
using Grpc.Core;
using static Shared.GeneratedCode.SmallPayloadService;

namespace GrpcServer
{
    public class SmallPayloadImplementation : SmallPayloadServiceBase
    {
        public override Task<SmallResponse> SendSmallPayload(SmallRequest request, ServerCallContext context)
        {
            return Task.FromResult(
                new SmallResponse
                {
                    Message = "SmallResponse"
                }
           );
        }
    }
}
