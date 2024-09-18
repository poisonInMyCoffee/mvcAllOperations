using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using First_MVC_App.Models;



namespace First_MVC_App.Controllers
{
    public class HomeController : Controller
    {
        List<Product> ProductLists = new List<Product>()
        {
            new Product { id = 32,name="Rayban Sunglasses",price=10000,picture="~/Image/Sunglass.jpg" },
            new Product { id = 42,name="Rolex Watch",price=1000000,picture="~/Image/Watch.jpg" },
            new Product { id = 52,name="Shoes",price=1000,picture="~/Image/Shoes.jpg" }
        };


        public ActionResult Index()
        {ViewBag.message = "This website runs on hope and electricity";

            return View();
        }

        public ActionResult Product()
        {
            ViewBag.message = "products on sale";

            return View(ProductLists);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Here is the company description";

            Employee Utk = new Employee();
            Utk.id = 302;
            Utk.name = "Sanidhya";
            Utk.age = 25;

            Employee Aman = new Employee();
            Aman.id = 304;
            Aman.name = "Aman";
            Aman.age = 28;

            Employee Atul = new Employee();
            Atul.id = 305;
            Atul.name = "Atul";
            Atul.age = 55;

            Employee Ajay = new Employee();
            Ajay.id = 305;
            Ajay.name = "Ajay";
            Ajay.age = 45;

            ViewData["var1"] = Utk;
            ViewBag.var2 = Utk;

            List<Employee> emp = new List<Employee>();
            emp.Add(Utk);
            emp.Add(Aman);
            emp.Add(Atul);
            emp.Add(Ajay);


            return View(emp);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Enroll()
        {
            ViewBag.Message = "Enter applicant's details"; ;

            return View();
        }
    }
}