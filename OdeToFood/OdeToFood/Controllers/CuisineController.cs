using OdeToFood.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    // [Authorize] // could have applied an action filter at the controller level too
    public class CuisineController : Controller
    {

        // GET: Cuisine
        [Log]
        //[Authorize] // This is an action filter - user must be logged in to use search
        // Actions are just public methods inside a controller class
        public ActionResult Search(string name)
        {
            throw new Exception("ruh roh");
            var message = Server.HtmlEncode(name);
            return Content(message);
            //return RedirectToRoute("Default", new { controller = "Home", action = "About" }); // redirect to an action (index action, home controller)
            //return File(Server.MapPath("~/Content/site.css"), "text/css");
            //return Json(new { Message = message, Name = "Scott" }, JsonRequestBehavior.AllowGet);
        }
        //[HttpGet]
        //public ActionResult Search()
        //{
        //    var message = Server.HtmlEncode(name);
        //    return Content(message);
        //}
    }
}