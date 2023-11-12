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
            try
            {
                if (register.UserName!=string.Empty&&register.Password!=string.Empty)
                {
                    AppUserProfile profile = new()
                    {
                     BirthDate=register.BirthDate,
                     FirstName=register.FirstName,
                     LastName=register.LastName,
                    };
                    AppUser user = new()
                    {
                        UserName = register.UserName,
                        Password = register.Password,
                        Profile=profile,
                        Admin=false
                    };
                    _db.Add(user);
                    _db.SaveChanges();
                    return RedirectToAction("Index","Login");

                }

            }
            catch 
            {

                RegisterUserSharedPageVM vm = new()
                {
                    Register = register
                };
                return View(vm);
            }

            return View();
        }
    }
}
