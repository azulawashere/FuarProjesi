using Microsoft.AspNetCore.Mvc;

namespace FuarProjesi.Controllers
{
    public class PlaceController : Controller
    {
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
