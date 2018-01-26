using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ticked.Models;

namespace Ticked.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index() {
            HomeModel hModel = new HomeModel {
                PageTextSwedish = "Välkommen till Ticked",
                PageTextEnglish = "Welcome to Ticked"
            };
            ViewData["Pagetext"] = hModel;
            return View();
        }
    }
}