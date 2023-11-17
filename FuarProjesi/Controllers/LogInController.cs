using FuarProjesi.Models.ContextClasses;
using FuarProjesi.Models.Entities;
using FuarProjesi.Models.LogIn.PageVMs;
using FuarProjesi.Models.LogIn.RequestModels;
using Microsoft.AspNetCore.Mvc;

namespace FuarProjesi.Controllers
{
    public class LogInController : Controller
    {
        MyContext _db;
        public LogInController(MyContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Index(LogInRequestModel logIn)
        {return View(logIn);
        }

    }
}
