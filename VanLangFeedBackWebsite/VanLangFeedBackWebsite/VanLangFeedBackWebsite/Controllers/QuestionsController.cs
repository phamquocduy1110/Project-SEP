using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VanLangFeedBackWebsite.Models;

namespace VanLangFeedBackWebsite.Controllers
{
    public class QuestionsController : Controller
    {
        DIEUBANTHUONGHOIWEBSITEEntities model = new DIEUBANTHUONGHOIWEBSITEEntities();

        public ActionResult Search(string keyword)
        {
            var search = model.CAU_HOI.ToList();
            search = search.Where(p => p.CAU_HOI1.ToLower().Contains(keyword.ToLower())).ToList();
            ViewBag.keyword = keyword;
            return View("Index2", search);
        }

        // GET: Questions
        public ActionResult Index()
        {
            var question = model.CAU_HOI.ToList();
            return View(question);
        }
    }
}