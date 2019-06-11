using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Models.User
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string PasswordBase64 { get; set; }
        public string Name { get; set; }
        public string Secondname { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        private string avatarLink;
        public string AvatarLink {
            get {
                return "../../Images/UserAvatars/" + avatarLink;
            } set {
                avatarLink = value;
            }
        }
        public string Role { get; set; }

        public bool IsInRole(string role)
        { return Role == role; }

        public string FullName {
            get {
                return string.Format("{0} {1}", Name, Secondname);
            }
        }
    }
}