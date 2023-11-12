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
        {
            try
            {
                if (logIn.UserName != null && logIn.Password != null)
                {
                    
                    AppUser appU = _db.AppUsers.Where(x => x.UserName == logIn.UserName && x.Password == logIn.Password).FirstOrDefault();
                    if (appU != null)
                    {
                        if (appU.Admin)
                        {
                            return RedirectToAction("Index", "Admin");
                        }
                        else if (appU.Admin == false)
                        {
                            return RedirectToAction("Index", "User");
                        }
                        else
                        {
                            ViewBag.Message = "Username or Password isn't correct";
                            LogInUserSharedPageVM logInUSPVM = new LogInUserSharedPageVM()
                            {
                                LogIn = logIn
                            };
                            return View(logInUSPVM);
                        }
                    }
                }
            }
            catch
            {
                
            }
            return View();
        }

    }
}
