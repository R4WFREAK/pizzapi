using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace pizzapi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PizzaController : Controller
    {
        public PizzaController()
        {
            
        }

        public async Task<IActionResult> Post()
        {
            return Ok();
        }
    }
}