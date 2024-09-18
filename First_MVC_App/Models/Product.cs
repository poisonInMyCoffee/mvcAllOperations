using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace First_MVC_App.Models
{
    public class Product
    {
        public int id { get; set; }
        public String name { get; set; }
        public double price { get; set; }
        public String picture { get; set; }
    }
}