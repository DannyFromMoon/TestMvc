using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestMvc.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CheckUser(string name, string address)
        {




            return Json("{'name':1}", JsonRequestBehavior.AllowGet);

            //return Content("{'name':1}");
        }
    }
}