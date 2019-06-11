using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Models.User
{
    public class WorkUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Secondname { get; set; }
        public string FullName
        {
            get
            {
                return Name + " " + Secondname;
            }
        }

        public string Email { get; set; }
        public string Avatar { get; set; }
        public string LinkToAvatar
        {
            get
            {
                return "../Images/UserAvatars/" + Avatar;
            }
        }
    }
}