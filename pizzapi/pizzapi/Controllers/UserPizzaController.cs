using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace pizzapi.Controllers
{
    [Route("User/{userId:int}/Pizza")]
    [ApiController]
    public class UserPizzaController : Controller
    {
        public UserPizzaController()
        {
            
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok();
        }
    }
}