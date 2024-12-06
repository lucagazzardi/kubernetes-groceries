using Microsoft.AspNetCore.Mvc;

namespace List_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ListController : ControllerBase
    {
        private readonly ILogger<ListController> _logger;

        public ListController(ILogger<ListController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            return "One day I will return the groceries lists... maybe";
        }
    }
}
