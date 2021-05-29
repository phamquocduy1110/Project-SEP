using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VanLangFeedBackWebsite.Controllers
{
    public class AdminHomeController : Controller
    {
        // GET: Admin
        public ActionResult AdminIndex()
        {
            return View();
        }

        public ActionResult AdminTable()
        {
            return View();
        }
    }
}