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

        public ActionResult AddComment(int id,string comment )
        {
            if (!string.IsNullOrEmpty(comment))
            {
                list.Add(new CommentEntity()
                     {
                         Id = id,
                         Text = comment
                     });
                if (Request.IsAjaxRequest())
                    return Json(list);
                return RedirectToAction("Index");
            }
            else return HttpNotFound();
        }

    }
}
