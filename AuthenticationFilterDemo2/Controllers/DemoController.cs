using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AuthenticationFilterDemo2.Models;

namespace AuthenticationFilterDemo2.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(User1 user)
        {
            if(user.uname == "user" && user.pass == "user")
            {
                return RedirectToAction("Index","Home");   
            }
            return RedirectToAction("Index", "Home");

        }
    }
}