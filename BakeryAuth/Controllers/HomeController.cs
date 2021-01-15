using Microsoft.AspNetCore.Mvc;
using System.Dynamic;
using System.Linq;
using BakeryAuth.Models;

namespace BakeruAuth.Controllers
{
    public class HomeController : Controller
    {
        private readonly BakeryAuthContext _db;

        public HomeController(BakeryAuthContext db)
        {
            _db = db;
        }
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Show()
        {
            dynamic model = new ExpandoObject();
            model.Flavors = _db.Flavors.ToList();
            model.Treats = _db.Treats.ToList();
            return View(model);
        }

    }
}