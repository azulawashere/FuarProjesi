using FuarProjesi.Models.Register.RequestModels;
using Microsoft.AspNetCore.Mvc;

namespace FuarProjesi.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult SignUp()
        {


            return View();
        }
        [HttpPost]
        public IActionResult SignUp(RegisterRequestModel register)
        {


            return View();
        }
    }
}
