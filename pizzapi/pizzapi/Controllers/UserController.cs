using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace pizzapi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        public UserController()
        {
            
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Put()
        {
            return Ok();
        }
    }
}