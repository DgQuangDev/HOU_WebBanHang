using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebBanHang.Objects
{
    public class User
    {
        public string number { get; set; }
        public string username { get; set; }
        public string password { get; set; }

        public User(string number, string username, string password)
        {
            this.number = number;
            this.username = username;
            this.password = password;
        }
    }
}