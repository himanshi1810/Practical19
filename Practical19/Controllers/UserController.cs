using Microsoft.AspNetCore.Mvc;

namespace Practical19.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
