using Microsoft.AspNetCore.Mvc;
using Singleton_AspNetCore_Example.Services;

namespace Singleton_AspNetCore_Example.Controllers
{
    [Route("api/values")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet("[action]")]
        public IActionResult X()
        {
            DatabaseService databaseService = DatabaseService.Instance;
            databaseService.Connection();
            databaseService.Disconnection();
            return Ok();
        }

        [HttpGet("[action]")]
        public IActionResult Y()
        {
            DatabaseService databaseService = DatabaseService.Instance;
            databaseService.Connection();
            databaseService.Disconnection();
            return Ok();
        }
    }
}
