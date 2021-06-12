using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using dieubanthuonghoi.Models;

namespace dieubanthuonghoi.Areas.Admin.Controllers
{
    public class ListQuestionsAdminController : Controller
    {
        QUANLYCANTEENEntities model = new QUANLYCANTEENEntities();
        
        // GET: Admin/ListQuestionsAdmin
        public ActionResult Index()
        {
            var product = model.FOODs.ToList().OrderByDescending(x => x.ID).ToList();
            return View(product);
        }
    }
}