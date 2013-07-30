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
            //response.write("asas");

            Response.Write("ERT:test");
            Response.Write("Omr:test");
            
            
            
            
            // guncelleme yaptim

            // ömer : güncelleme yaptım
            
            // ömer : merge



            //Ömer 2 : merge

            return View();
        }
    }
}
