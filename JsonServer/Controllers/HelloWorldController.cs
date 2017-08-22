using Microsoft.AspNetCore.Mvc;
using Shared;

namespace JsonServer.Controllers
{
    public class HelloWorldController : Controller
    {
        [HttpGet]
        [Route("/small")]
        public IActionResult Small(SmallRequest request) => new OkObjectResult(Shared.SmallResponse.Create());

        [HttpGet]
        [Route("/huge")]
        public IActionResult Small(HugeRequest request) => new OkObjectResult(Shared.HugeResponse.Create());
    }
}
