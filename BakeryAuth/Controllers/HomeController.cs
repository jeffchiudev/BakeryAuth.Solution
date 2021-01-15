using Microsoft.AspNetCore.Mvc;

namespace BakeruAuth.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }
    }
}