using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GrpcService1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmptyController : ControllerBase
    {

        [HttpGet("")]
        public IActionResult Sample()
        {
            return Ok("dupa");
        }
    }
}
