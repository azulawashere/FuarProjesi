using FuarProjesi.Models.ContextClasses;
using Microsoft.AspNetCore.Mvc;

namespace FuarProjesi.Controllers
{
    public class PlaceController : Controller
    {
        MyContext _db;

        public PlaceController(MyContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreatePlace()
        {
            return View();
        }
    }
}
