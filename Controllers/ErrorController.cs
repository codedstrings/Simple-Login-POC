using Microsoft.AspNetCore.Mvc;

namespace Simple_Login_POC.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
