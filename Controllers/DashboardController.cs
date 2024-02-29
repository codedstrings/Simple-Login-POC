using Microsoft.AspNetCore.Mvc;
using Simple_Login_POC.Models;

namespace Simple_Login_POC.Controllers
{
    public class DashboardController : Controller
    {
        public ActionResult Index(User loginUser)
        {
            return View(loginUser);
        }
    }
}
