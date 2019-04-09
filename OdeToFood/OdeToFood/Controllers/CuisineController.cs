using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    public class CuisineController : Controller
    {
  
        // GET: Cuisine

        // Actions are just public methods inside a controller class
        public ActionResult Search(string name)
        {
            var message = Server.HtmlEncode(name);
            //return Content(message);
            //return RedirectToRoute("Default", new { controller = "Home", action = "About" }); // redirect to an action (index action, home controller)
            //return File(Server.MapPath("~/Content/site.css"), "text/css");
            return Json(new { Message = message, Name = "Scott" }, JsonRequestBehavior.AllowGet);
        }
    }
}