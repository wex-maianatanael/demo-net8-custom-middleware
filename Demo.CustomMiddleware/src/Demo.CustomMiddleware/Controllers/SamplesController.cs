using Microsoft.AspNetCore.Mvc;

namespace Demo.CustomMiddleware.Controllers
{
    [ApiController]
    [Route("api/samples")]
    public class SamplesController : ControllerBase
    {
        private readonly ILogger<SamplesController> _logger;

        public SamplesController(ILogger<SamplesController> logger)
        {
            _logger = logger;
        }

        [HttpGet()]
        public async Task<IActionResult> Get()
        {
            return Ok();
        }
    }
}
