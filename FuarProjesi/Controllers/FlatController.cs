using FuarProjesi.Models.ContextClasses;
using FuarProjesi.Models.Entities;
using FuarProjesi.Models.Flats.PageVms;
using FuarProjesi.Models.Flats.PureVms;
using FuarProjesi.Models.Flats.RequestModels;
using FuarProjesi.Models.Flats.ResponseModels;
using FuarProjesi.Models.MapperClasses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FuarProjesi.Controllers
{
    [Authorize(Roles = "Admin")]
    public class FlatController : Controller
    {
        MyContext _db;
        public FlatController(MyContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CreateFlat()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateFlat(CreateFlatRequestModel flat)
        {
            Flat f = new()
            {
                FlatPrice = flat.FlatPrice,
                FlatNo = flat.FlatNo,
                FloorNo = flat.FloorNo,
                MSquare = flat.MSquare,
                FlatPopulation = flat.FlatPopulation
            };
            _db.Flats.Add(f);
            _db.SaveChanges();
            return RedirectToAction("GetFlats");
        }
        public IActionResult GetFlats() 
        {
            List<FlatResponseModel> flats = _db.Flats.Select(x => new FlatResponseModel 
            {
                ID = x.ID,
                FlatPrice = x.FlatPrice,
                FlatNo = x.FlatNo,
                FloorNo = x.FloorNo,
                MSquare = x.MSquare,
                FlatPopulation = x.FlatPopulation
            }).ToList();

            FlatResponsePageVM fRpgvm = new FlatResponsePageVM
            {
                Flats = flats
            };
            return View(fRpgvm);
        }
        public IActionResult UpdateFlat(int id)
        {
            FlatVM flat = FlatMapper.GetFlatVM(_db.Flats.Find(id));

            FlatSharedPageVM fSpvm = new()
            {
                Flat = flat,
            };
            return View(fSpvm);
        }

        [HttpPost]
        public IActionResult UpdateFlat(FlatVM flat)
        {
            Flat original = _db.Flats.Find(flat.ID);
            original.FlatPrice = flat.FlatPrice;
            original.FlatNo = flat.FlatNo;
            original.FloorNo = flat.FloorNo;
            original.MSquare = flat.MSquare;
            original.FlatPopulation = flat.FlatPopulation;
            _db.SaveChanges();
            TempData["message"] = "update successful";
            return RedirectToAction("GetFlats");
        }

        public IActionResult DeleteFlat(int id)
        {
            _db.Flats.Remove(_db.Flats.Find(id));
            _db.SaveChanges();
            return RedirectToAction("GetFlats");
        }
    }
}
