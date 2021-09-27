using Microsoft.AspNetCore.Mvc;
using ANZ104AngularDemo.Web.Controllers;

namespace ANZ104AngularDemo.Web.Public.Controllers
{
    public class HomeController : ANZ104AngularDemoControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}