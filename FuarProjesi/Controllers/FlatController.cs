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
        public IActionResult CreateFlat(int id)
        {
            FlatRequestPageVM model = new()
            {
                PlaceID=id,
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult CreateFlat(FlatRequestPageVM model)
        {
            Flat f = new()
            {
                PlaceID = model.PlaceID,
                FlatPrice = model.Flat.FlatPrice,
                FlatNo = model.Flat.FlatNo,
                FloorNo = model.Flat.FloorNo,
                MSquare = model.Flat.MSquare,
                FlatPopulation = model.Flat.FlatPopulation
            };
            _db.Flats.Add(f);
            _db.SaveChanges();
            TempData["id"]=model.PlaceID;
            return RedirectToAction("GetFlats",model);
        }
        public IActionResult GetFlats(int id) 
        {
            if (id==0)
            {
                id = Convert.ToInt32( TempData["id"]);
            }
            List<FlatResponseModel> flats = _db.Flats.Where(x=>x.PlaceID==id).Select(x => new FlatResponseModel 
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
                Flats = flats,
                PlaceID = id,
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
        public IActionResult UpdateFlat(FlatSharedPageVM model)
        {
            Flat original = _db.Flats.Find(model.Flat.ID);
            original.FlatPrice = model.Flat.FlatPrice;
            original.FlatNo = model.Flat.FlatNo;
            original.FloorNo = model.Flat.FloorNo;
            original.MSquare = model.Flat.MSquare;
            original.FlatPopulation = model.Flat.FlatPopulation;
            _db.SaveChanges();
            TempData["message"] = "update successful";
            TempData["id"] = original.PlaceID;
            return RedirectToAction("GetFlats");
        }

        public IActionResult DeleteFlat(int id)
        {
            Flat f = _db.Flats.Find(id);
            TempData["id"] =f.PlaceID;
            _db.Flats.Remove(f);

            _db.SaveChanges();
            return RedirectToAction("GetFlats");
        }
    }
}
