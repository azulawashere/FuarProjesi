using FuarProjesi.Models.Categories.PageVms;
using FuarProjesi.Models.Categories.PureVms;
using FuarProjesi.Models.Categories.ResponseModels;
using FuarProjesi.Models.ContextClasses;
using FuarProjesi.Models.Entities;
using FuarProjesi.Models.FoodServices.PageVms;
using FuarProjesi.Models.FoodServices.PureVms;
using FuarProjesi.Models.FoodServices.RequestModels;
using FuarProjesi.Models.FoodServices.ResponseModels;
using FuarProjesi.Models.MapperClasses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FuarProjesi.Controllers
{
    [Authorize(Roles ="Admin")]
    public class FoodServiceController : Controller
    {
        MyContext _db;
        public FoodServiceController(MyContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateFoodService()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateFoodService(CreateFoodServiceRequestModel foodService)
        {
            FoodService fS = new()
            {
                ServiceName = foodService.ServiceName,
                ServicePrice = foodService.ServicePrice
            };
            _db.FoodServices.Add(fS);
            _db.SaveChanges();
            return RedirectToAction("GetFoodServices");
        }

        public IActionResult GetFoodServices()
        {
            List<FoodServiceResponseModel> foodServices = _db.FoodServices.Select(x => new FoodServiceResponseModel
            {
                ID = x.ID,
                ServiceName = x.ServiceName,
                ServicePrice = x.ServicePrice
            }).ToList();
            FoodServiceResponsePageVM fSpvm = new FoodServiceResponsePageVM
            {
                FoodServices = foodServices
            };

            return View(fSpvm);
        }

        public IActionResult UpdateFoodService(int id)
        {
            FoodServiceVM foodService = FoodServiceMapper.GetFoodServiceVM(_db.FoodServices.Find(id));

            FoodServiceSharedPageVM FSpVm = new()
            {
                FoodService = foodService,
            };


            return View(FSpVm);
        }

        [HttpPost]
        public IActionResult UpdateFoodService(FoodServiceVM foodService)
        {
            FoodService original = _db.FoodServices.Find(foodService.ID);
            original.ServiceName = foodService.ServiceName;
            original.ServicePrice = foodService.ServicePrice;

            _db.SaveChanges();
            TempData["message"] = "update successful";
            return RedirectToAction("GetFoodServices");
        }

        public IActionResult DeleteFoodService(int id)
        {
            _db.FoodServices.Remove(_db.FoodServices.Find(id));
            _db.SaveChanges();
            return RedirectToAction("GetFoodServices");
        }
    }
}
