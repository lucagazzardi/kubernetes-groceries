using Microsoft.AspNetCore.Mvc;

namespace Catalog_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CatalogController : ControllerBase
    {
        private readonly ILogger<CatalogController> _logger;

        public CatalogController(ILogger<CatalogController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            return "One day I will return the catalog... maybe";
        }
    }
}
