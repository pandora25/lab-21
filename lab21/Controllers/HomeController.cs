using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lab21.Models;

namespace lab21.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult SignUpForm()
        {
            return View();
        }

        public ActionResult AddNewUser(UserInfo newUser)
        {
            //validations
            if (ModelState.IsValid)
            {
                // insert the new into the db!
                ViewBag.Message = $"Welcom {newUser.UserName}";
                return View("Confirm");
            }
            else
            {
                ViewBag.Address = Request.UserHostAddress;
                return View("Error");
            }

        }
        

    }
}