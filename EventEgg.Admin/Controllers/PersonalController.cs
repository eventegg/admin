using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EventEgg.Admin.Models;

namespace EventEgg.Admin.Controllers
{
    public class PersonalController : Controller
    {
        /// <summary>
        /// Login Page
        /// </summary>
        /// <returns></returns>
        public ActionResult Login()
        {
            var model = new PersonalLoginPageModel();
            return View(model);
        }

        [HttpPost]
        [HandleError]
        public ActionResult Login(PersonalLoginPageModel model)
        {
            return View(model);
        }

        /// <summary>
        /// Register Page
        /// </summary>
        /// <returns></returns>
        public ActionResult Register()
        {
            return View();
        }

        /// <summary>
        /// Lost Password Page
        /// </summary>
        /// <returns></returns>
        public ActionResult LostPassword()
        {
            return View();
        }
    }
}
