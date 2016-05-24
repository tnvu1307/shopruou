using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopRuou.Models
{
    public class RegisterModel
    {
        public string UID { get; set; }
        public string PWD { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Birthday { get; set; } 
    }
}