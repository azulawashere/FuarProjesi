
using FuarProjesi.Models.ContextClasses;
using FuarProjesi.Models.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FuarProjesi.Controllers
{

    public class AdminController : Controller
    {
        MyContext _db;


        public AdminController(MyContext db)
        {
            _db = db;
        }



        public IActionResult CreateCategory()
        {
            return View();
        }

    
   

        public IActionResult DeleteCategory(int id)
        {
            _db.Categories.Remove(_db.Categories.Find(id));
            _db.SaveChanges();
            return RedirectToAction("GetCategories");
        }


    }

}
