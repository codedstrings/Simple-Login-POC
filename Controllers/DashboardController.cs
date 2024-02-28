using Microsoft.AspNetCore.Mvc;

namespace Simple_Login_POC.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
