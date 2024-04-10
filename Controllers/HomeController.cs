using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : Controller
    {
      
        [HttpGet]
        public IActionResult get()
        {
            return Ok("Hi this is sample view");
        }
    }
}
