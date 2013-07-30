using EventEgg.Admin.Models;
using EventEgg.Service;
using System.Web.Mvc;
using System.Web.Security;
using System.Linq;
using EventEgg.Service.Models;

namespace EventEgg.Admin.Controllers
{
    public class MenuController : Controller
    {
        private PersonalService _personalService;

        public PartialViewResult MenuHeader()
        {
            _personalService = new PersonalService();
            var model = new MenuHeaderPageModel();
            var email = FormsAuthentication.Decrypt(Request.Cookies[FormsAuthentication.FormsCookieName].Value).Name;
            var personalDetailModel = _personalService.GetSingle(k => k.Email == email);
            model.FullName = personalDetailModel.FullName;
            return PartialView(model);
        }
        public PartialViewResult MenuLeft()
        {
            return PartialView();
        }
        public PartialViewResult MenuFooter()
        {
            return PartialView();
        }
    }
}
