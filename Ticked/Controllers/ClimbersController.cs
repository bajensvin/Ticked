using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ticked.Models;

namespace Ticked.Controllers
{
    public class ClimbersController : Controller {
        // GET: Climbers
        public ActionResult Index() {
            ClimbersModel cModel = new ClimbersModel("", "", "");
            ViewBag.Message = "Hello " + cModel.fName + ' ' + cModel.lName + ' ' + cModel.hGym;
            return View();
        }
    }
}