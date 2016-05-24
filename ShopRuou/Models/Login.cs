using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopRuou.Models
{
    public class Login
    {
        public string user { get; set; }
        public string pass { get; set; }
        public bool remember { get; set; }
    }
}