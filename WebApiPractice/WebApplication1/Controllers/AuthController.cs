using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpPost]
        public ActionResult Login()
        {
            return Ok("Login");
        }

        [HttpPost]
        public ActionResult Register()
        {
            return Ok("Register");
        }
    }
}
