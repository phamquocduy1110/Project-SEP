using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VanLangFeedBackWebsite.Models;

namespace VanLangFeedBackWebsite.Areas.Admin.Controllers
{
    public class ManageCatalogController : Controller
    {
        DIEUBANTHUONGHOIWEBSITEEntities model = new DIEUBANTHUONGHOIWEBSITEEntities();
        // GET: Admin/AdminManageCatalog
        public ActionResult Index()
        {
            var category = model.DANH_MUC.ToList().OrderByDescending(x => x.ID).ToList();
            return View(category);
        }
    }
}