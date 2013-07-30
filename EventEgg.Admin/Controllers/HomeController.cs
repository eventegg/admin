using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EventEgg.Admin.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        [Authorize(Roles = "SystemAdmin")]
        public ActionResult Index()
        {
            response.write("asas");
            return View();
        }
    }
}
