using OdeToFood.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    //[Authorize]
    [Log]
    public class CuisineController : Controller
    {
        public ActionResult Search(string name)
        {
            throw new Exception("An error ocurred!");
            var message = Server.HtmlEncode(name);
            return Content(message);
        }
    }
}