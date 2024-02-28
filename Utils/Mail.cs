using System.Net.Mail;
using System.Net;

namespace Simple_Login_POC.Utils
{
    public class Mail
    {
        public void sendMail(Models.User user)
        {
            //Email sending logic
            string fromAddress = "christmasiesk@gmail.com";
            string password = "nphf ersw wtbz bgzi";

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(fromAddress, password),
                EnableSsl = true,
            };

            //setting up mail using MailMessage
            var mailMessage = new MailMessage()
            {
                From = new MailAddress(fromAddress),
                Subject = "OTP",
                Body = $"The otp is : {user.otp} , Do not share your otp with anyone.",
                IsBodyHtml = true,
            };
            mailMessage.To.Add(user.Email);
            smtpClient.Send(mailMessage);
        }
       
    }
}
