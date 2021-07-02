using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using VanLangFeedBackWebsite.Models;

namespace VanLangFeedBackWebsite.Controllers
{
    public class QuestionsController : Controller
    {
        DIEUBANTHUONGHOIWEBSITEEntities model = new DIEUBANTHUONGHOIWEBSITEEntities();

        [AllowAnonymous]
        public ActionResult Search(string keyword, int? page)
        {
            var pageNumber = page ?? 1;
            var pageSize = 10;

            var search = model.CAU_HOI.OrderByDescending(x => x.ID).Where(x => x.CAU_HOI1.ToLower().Contains(keyword.ToLower())).ToPagedList(pageNumber, pageSize);
            ViewBag.keyword = keyword;
            return View("Index", search);
        }

        // GET: Questions
        public ActionResult Index(int? page)
        {
            var pageNumber = page ?? 1;
            var pageSize = 3;

            var quesionList = model.CAU_HOI.OrderByDescending(x => x.ID).ToPagedList(pageNumber, pageSize);
            return PartialView(quesionList);
        }

        public PartialViewResult CategoryPartical(int ? page)
        {
            var pageNumber = page ?? 1;
            var pageSize = 3;

            var categoryList = model.DANH_MUC.OrderByDescending(x => x.DANH_MUC1).ToPagedList(pageNumber, pageSize);
            return PartialView(categoryList);
        }

        /*public ActionResult QuestionListPartical(int? page, int? category)
        {
            var pageNumber = page ?? 1;
            var pageSize = 10;

            if (category != null)
            {
                var quesionList = model.CAU_HOI
                                .OrderByDescending(x => x.ID)
                                .Where(x => x.ID_DANH_MUC == category)
                                .ToPagedList(pageNumber, pageSize);
                return PartialView(quesionList);
            }
            else
            {
                var quesionList = model.CAU_HOI
                                .OrderByDescending(x => x.ID)
                                .ToPagedList(pageNumber, pageSize);
                return PartialView(quesionList);
            }
        }*/
    }
}