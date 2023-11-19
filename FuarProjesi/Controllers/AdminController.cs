
using FuarProjesi.Models.Categories.RequestModels;
using FuarProjesi.Models.ContextClasses;
using FuarProjesi.Models.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FuarProjesi.Controllers
{
    //DESKTOP-ANIL\\SQLEXPRESS04;database=FuarDBOriginal
    public class AdminController : Controller
    {
        MyContext _db;


        public AdminController(MyContext db)
        {
            _db = db;
        }
        //DESKTOP-A01RV81\\SQLEXPRESS;database=FuarDB
        public IActionResult Index() 
        {
            return View();
        }

       
   


    }

}
