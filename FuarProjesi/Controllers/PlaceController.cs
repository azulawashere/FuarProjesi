using FuarProjesi.Models.ContextClasses;
using FuarProjesi.Models.Entities;
using FuarProjesi.Models.MapperClasses;
using FuarProjesi.Models.Places.PageVms;
using FuarProjesi.Models.Places.PureVms;
using FuarProjesi.Models.Places.RequestModels;
using FuarProjesi.Models.Places.ResponseModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FuarProjesi.Controllers
{
    [Authorize(Roles ="Admin")]
    public class PlaceController : Controller
    {
        MyContext _db;

        public PlaceController(MyContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreatePlace()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreatePlace(CreatePlaceRequestModel place)
        {
            Place p = new()
            {
                PlaceName = place.PlaceName,
                Adress = place.Adress,
            };
            _db.Places.Add(p);
            _db.SaveChanges();
            return RedirectToAction("GetPlaces");
        }

        public IActionResult GetPlaces()
        {
            List<PlaceResponseModel> places= _db.Places.Select(x => new PlaceResponseModel
            {
                ID = x.ID,
                PlaceName = x.PlaceName,
                Adress = x.Adress,
            }).ToList();
            PlaceResponsePageVM pRpvm = new PlaceResponsePageVM
            {
                Places = places
            };

            return View(pRpvm);
        }

        public IActionResult UpdatePlace(int id)
        {
            PlaceVM place = PlaceMapper.GetPlaceVM(_db.Places.Find(id));

            PlaceSharedPageVM pSpVm = new()
            {
                Place = place,
            };
            return View(pSpVm);
        }

        [HttpPost]
        public IActionResult UpdatePlace(PlaceVM place)
        {
            Place original = _db.Places.Find(place.ID);
            original.PlaceName = place.PlaceName;
            original.Adress = place.Adress;
            _db.SaveChanges();
            TempData["message"] = "update successful";
            return RedirectToAction("GetPlaces");
        }

        public IActionResult DeletePlace(int id)
        {
            _db.Places.Remove(_db.Places.Find(id));
            _db.SaveChanges();
            return RedirectToAction("GetPlaces");
        }
    }
}
