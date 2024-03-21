using Microsoft.AspNetCore.Mvc;

namespace _1403ASPNET.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
