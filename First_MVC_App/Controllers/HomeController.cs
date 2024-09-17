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
        public ActionResult Index()
        {
            return View();
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

            ViewData["var1"] = Utk;
            ViewBag.var2 = Utk;

            List<Employee> emp = new List<Employee>();
            emp.Add(Utk);
            emp.Add(Aman);
            emp.Add(Atul);


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