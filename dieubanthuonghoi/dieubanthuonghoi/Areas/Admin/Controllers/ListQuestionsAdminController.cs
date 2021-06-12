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
        private const string PICTURE_PATH = "~/Upload/SanPhams/";

        // GET: Admin/ListQuestionsAdmin
        public ActionResult Index()
        {
            var product = model.FOODs.ToList().OrderByDescending(x => x.ID).ToList();
            return View(product);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var product = model.FOODs.FirstOrDefault(x => x.ID == id);
            ViewBag.product_type = model.CATEGORies.OrderByDescending(x => x.ID).ToList();
            return View(product);
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult Edit(int id, FOOD f, HttpPostedFileBase IMAGE_URL)
        {
            var product = model.FOODs.FirstOrDefault(x => x.ID == id);
            product.FOOD_CODE = f.FOOD_CODE;
            product.FOOD_NAME = f.FOOD_NAME;
            product.DESCRIPTION = f.DESCRIPTION;
            product.CATEGORY = f.CATEGORY;
            product.PRICE = f.PRICE;
            product.IMAGE_URL = f.IMAGE_URL;
            product.STATUS = f.STATUS;
            model.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.product_type = model.CATEGORies.OrderByDescending(x => x.ID).ToList();
            return View();
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult Create(FOOD f, HttpPostedFileBase IMAGE_URL)
        {
            var product = new FOOD();

            product.FOOD_CODE = f.FOOD_CODE;
            product.FOOD_NAME = f.FOOD_NAME;
            product.DESCRIPTION = f.DESCRIPTION;
            product.PRICE = f.PRICE;
            product.STATUS = f.STATUS;
            product.CATEGORY_ID = f.CATEGORY_ID;
            model.FOODs.Add(product);
            model.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var product = model.FOODs.FirstOrDefault(x => x.ID == id);
            return View(product);
        }


        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirm(int id)
        {
            var product = model.FOODs.FirstOrDefault(x => x.ID == id);
            model.FOODs.Remove(product);
            model.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet, ValidateInput(false)]
        public ActionResult Details(int id)
        {
            var product = model.FOODs.FirstOrDefault(x => x.ID == id);
            return View(product);
        }
    }
}