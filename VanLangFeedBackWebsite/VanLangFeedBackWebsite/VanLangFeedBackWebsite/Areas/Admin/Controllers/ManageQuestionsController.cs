﻿using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
/*using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
*/
using Microsoft.Owin.Security;
using VanLangFeedBackWebsite.Models;

namespace VanLangFeedBackWebsite.Areas.Admin.Controllers
{
    public class ManageQuestionsController : Controller
    {

        // GET: Admin/AdminManageQuestions
        public ActionResult Index()
        {
/*            var question = model.QUESTIONS.ToList().OrderByDescending(x => x.ID).ToList();
*/            return View();
        }
    }
}