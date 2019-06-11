using Project.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Models.User
{
    public class UserIdentity
    {
        public MySQLController Controller;

        private HttpRequestBase request;
        public HttpRequestBase Request {
            get {
                if (Controller != null)
                    return Controller.Request;
                return request;
            }
            set {
                request = value;
            }
        }

        public int Id
        {
            get
            {
                if (Request.Cookies["auth_"] != null)
                    return Convert.ToInt32(Request.Cookies["auth_"]["id"]);
                return -1;
            }
        }

        public string Username {
            get {
                if (Request.Cookies["auth_"] != null)
                    return Request.Cookies["auth_"]["username"];
                return null;
            }
        }
        public string Name {
            get {
                if (Request.Cookies["auth_"] != null)
                    return Request.Cookies["auth_"]["name"];
                return null;
            }
        }
        public string Secondname {
            get {
                if (Request.Cookies["auth_"] != null)
                    return Request.Cookies["auth_"]["secondname"];
                return null;
            }
        }
        public string Email {
            get {
                if (Request.Cookies["auth_"] != null)
                    return Request.Cookies["auth_"]["email"];
                return null;
            }
        }
        public string Address {
            get {
                if (Request.Cookies["auth_"] != null)
                    return Request.Cookies["auth_"]["address"];
                return null;
            }
        }
        public string AvatarLink {
            get {
                if (Request.Cookies["auth_"] != null && !string.IsNullOrWhiteSpace(Request.Cookies["auth_"]["avatarlink"]))
                    return "../../Images/UserAvatars/" + Request.Cookies["auth_"]["avatarlink"];
                return "../../Images/UserAvatars/noAvatar.png";
            }
        }
        public string Role {
            get {
                if (Request.Cookies["auth_"] != null)
                    return Request.Cookies["auth_"]["role"];
                return null;
            }
        }

        public bool IsLoggedIn {
            get {
                return Request.Cookies["auth_"] != null;
            }
        }


        public string FullName {
            get {
                return string.Format("{0} {1}", Name, Secondname);
            }
        }

        public bool IsInRole(string role)
        { return Role == role; }
    }
}