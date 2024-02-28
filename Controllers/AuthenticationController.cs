using Microsoft.AspNetCore.Mvc;
using Simple_Login_POC.Models;

namespace Simple_Login_POC.Controllers
{
    public class AuthenticationController : Controller
    {
       public ActionResult Index() 
        { 
            return View();
        }
        
        public ActionResult AddUser(User user)
        {
            //db connection 
            UserDbContext dbContext = new UserDbContext();
          
            dbContext.Users.Add(user); //creates query
            dbContext.SaveChanges();//executes query
           
            //otp
            Random random = new Random();
            // Generate a random 4-digit number
            user.otp = random.Next(1000, 10000);
           
            //send otp
            //navigate to login page
            return View(user);

        }

    }
}
//var users = dbContext.Users.ToList();
//var selectedUser = dbContext.Users.Where(x => x.Email == "mridhul"&& x.Password=="123").FirstOrDefault();