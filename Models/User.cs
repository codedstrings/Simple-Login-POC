﻿using System.ComponentModel.DataAnnotations;

namespace Simple_Login_POC.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int otp { get; set; }
    }
}
