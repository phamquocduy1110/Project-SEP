using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Areas.Admin.Controllers
{
    public class ProductAdminController : Controller
    {
        MANAGEPRODUCTEntities model = new MANAGEPRODUCTEntities();

        // GET: Admin/ProductAdmin
        public ActionResult Index()
        {
            var product = model.PRODUCTs.OrderByDescending(x => x.ID).ToList();
            return View(product);
        }
    }
}