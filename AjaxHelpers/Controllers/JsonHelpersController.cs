using AjaxHelpers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxHelpers.Controllers
{
    public class JsonHelpersController : Controller
    {
        //
        // GET: /JsonHelpers/
        private static List<CommentEntity> list = new List<CommentEntity>();
        

        public ActionResult Index()
        {
            return View(list);
        }

        public ActionResult AddComment(CommentEntity newComment)
        {
            if (newComment!=null)
            {
                list.Add(newComment);
                if (Request.IsAjaxRequest())
                    return Json(newComment);
                return RedirectToAction("Index");
            }
            else return HttpNotFound();
        }

    }
}
