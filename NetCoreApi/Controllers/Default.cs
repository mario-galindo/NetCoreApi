using Microsoft.AspNetCore.Mvc;

namespace NetCoreApi.Controllers
{
    [ApiController]
    [Route("/")]
    public class Default : ControllerBase
    {
        [HttpGet]
        public string Index()
        {
            return "Running...";
        }

    }
}
