using Grpc.Core;
using System.Threading.Tasks;

namespace GrpcGreeting
{
    public class GreetingServiceImpl : GreetingService.GreetingServiceBase
    {
        public override Task<GreetingResponse> GetGreeting(GreetingRequest request, ServerCallContext context)
        {
            var response = new GreetingResponse
            {
                Message = $"Hello, {request.Name}!"
            };
            return Task.FromResult(response);
        }
    }
}
