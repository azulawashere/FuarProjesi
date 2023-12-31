﻿using FuarProjesi.Models.Categories.PageVms;
using FuarProjesi.Models.Categories.PureVms;
using FuarProjesi.Models.Categories.RequestModels;
using FuarProjesi.Models.Categories.ResponseModels;
using FuarProjesi.Models.ContextClasses;
using FuarProjesi.Models.Entities;
using FuarProjesi.Models.MapperClasses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FuarProjesi.Controllers
{
    [Authorize(Roles ="Admin")]
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
            return RedirectToAction("GetCategories");
        }
        public IActionResult GetCategories() 
        {
            List<CategoryResponseModel> categories = _db.Categories.Select(x => new CategoryResponseModel 
            {
                ID = x.ID,
                CategoryName = x.CategoryName
            }).ToList();
            CategoryResponsePageVM cpvm = new CategoryResponsePageVM
                {
                Categories = categories
            };


            return View(cpvm);
        }

        public IActionResult UpdateCategory(int id)
        { 
            CategoryVM category = CategoryMapper.GetCategoryVM(_db.Categories.Find(id));

            CategorySharedPageVM cpVm = new()
            {
                Category = category,
            };


            return View(cpVm);
        }
        [HttpPost]
        public IActionResult UpdateCategory(CategoryVM category)
        {
            Category original = _db.Categories.Find(category.ID);
            original.CategoryName = category.CategoryName;
            
            _db.SaveChanges();
            TempData["message"] = "update successful";
            return RedirectToAction("GetCategories");
        }
        public IActionResult DeleteCategory(int id)
        {
            _db.Categories.Remove(_db.Categories.Find(id));
            _db.SaveChanges();
            return RedirectToAction("GetCategories");
        }
    }
}
