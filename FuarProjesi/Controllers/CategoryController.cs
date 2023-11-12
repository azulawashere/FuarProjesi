using FuarProjesi.Models.Categories.RequestModels;
using FuarProjesi.Models.ContextClasses;
using FuarProjesi.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FuarProjesi.Controllers
{
    public class CategoryController : Controller
    {
        MyContext _db;
        public CategoryController(MyContext db)
        {
            _db = db;
        }



        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateCategory(CreateCategoryRequestModel category)
        {
            Category c = new()
            {
                CategoryName = category.CategoryName
            };
            _db.Categories.Add(c);
            _db.SaveChanges();
            return View();
        }



    }
}
