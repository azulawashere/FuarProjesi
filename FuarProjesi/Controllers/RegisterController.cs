using FuarProjesi.Models.ContextClasses;
using FuarProjesi.Models.Entities;
using FuarProjesi.Models.Register.PageVMs;
using FuarProjesi.Models.Register.RequestModels;
using Microsoft.AspNetCore.Mvc;

namespace FuarProjesi.Controllers
{
    public class RegisterController : Controller
    {
        MyContext _db;
        public RegisterController(MyContext db)
        {
            _db = db;
            
        }
        public IActionResult SignUp()
        {


            return View();
        }
        [HttpPost]
        public IActionResult SignUp(RegisterRequestModel register)
        {
         return RedirectToAction("Index");
        }
    }
}
