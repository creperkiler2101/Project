using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Models.User
{
    public class RegistrationUser
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string RePassword { get; set; }
        public string Name { get; set; }
        public string Secondname { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string AvatarLink { get; set; }
    }
}