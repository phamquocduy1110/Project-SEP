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

        [AllowAnonymous]
        public ActionResult Search(string keyword)
        {
            var search = model.CAU_HOI.ToList();
            search = search.Where(x => x.CAU_HOI1.ToLower().Contains(keyword.ToLower())).ToList();
            ViewBag.keyword = keyword;
            return View("Index", search);
        }

        // GET: Questions
        public ActionResult Index()
        {
            var question = model.CAU_HOI.ToList();
            return View(question);
        }
    }
}