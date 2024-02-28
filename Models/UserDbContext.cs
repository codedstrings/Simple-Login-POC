using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Simple_Login_POC.Models
{
    
    public class UserDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        //public DbSet<Feedback> Feedbacks { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string path = "Server=localhost\\SQLEXPRESS;Database=SampleDb1;Trusted_Connection=True;Encrypt=false;TrustServerCertificate=true";
            optionsBuilder.UseSqlServer(path);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
