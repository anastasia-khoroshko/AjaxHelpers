using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxHelpers.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        private static List<string> comments = new List<string>();

        public ActionResult Index()
        {
            return View(comments);
        }
        public ActionResult AddComment(string comment)
        {
            if (!string.IsNullOrEmpty(comment))
            {
                comments.Add(comment);
                if (Request.IsAjaxRequest())
                    return PartialView("_CommentsEntry", comment);
                return RedirectToAction("Index");
            }
            else return HttpNotFound();
        }
    }
}
