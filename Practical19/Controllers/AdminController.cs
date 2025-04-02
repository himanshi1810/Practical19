using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Practical19.Controllers
{
    [Authorize(Roles = "Admin")] // Only Admin can access this controller
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
