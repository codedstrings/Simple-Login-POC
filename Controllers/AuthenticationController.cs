using Microsoft.AspNetCore.Mvc;
using Simple_Login_POC.Models;
using Simple_Login_POC.Utils;

namespace Simple_Login_POC.Controllers
{
    public class AuthenticationController : Controller
    {
       public ActionResult Index() 
        { 
            return View();
        }
        
        public ActionResult Register(User user)
        {

            //otp
            Random random = new Random();
            // Generate a random 4-digit number
            user.otp = random.Next(1000, 10000);

            //send otp
            Mail mail = new Mail();
            mail.sendMail(user);

          
            //db connection 
            UserDbContext dbContext = new UserDbContext();
            dbContext.Users.Add(user); //creates query
            dbContext.SaveChanges();//executes query
                     
            //navigate to login page
            return RedirectToAction("Login");

        }
        public ActionResult Login()
        {
            return View();
        }

    }
}
//var users = dbContext.Users.ToList();
//var selectedUser = dbContext.Users.Where(x => x.Email == "mridhul"&& x.Password=="123").FirstOrDefault();