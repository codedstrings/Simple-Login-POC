using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        public ActionResult ValidateUser(User loginUser)
        {
            UserDbContext dbContext = new UserDbContext();
            //fetch userdata from db using email
            var userFromDb = dbContext.Users.FirstOrDefault(u => u.Email == loginUser.Email);
            //check if email and password match
            if (userFromDb != null && userFromDb.Password == loginUser.Password && userFromDb.otp==loginUser.otp)
            {
                //route to DashboadController
                return RedirectToAction("Index", "Dashboard",userFromDb);
            }
            else
            {
                //route to error
                return RedirectToAction("Index", "Error");
            }
               
                
        }
    }
} //var selectedUser = dbContext.Users.Where(u => u.Email == loginUser.Email && u.Password == loginUser.Password).FirstOrDefault();
  //var users = dbContext.Users.ToList();
  //var selectedUser = dbContext.Users.Where(x => x.Email == "mridhul"&& x.Password=="123").FirstOrDefault();