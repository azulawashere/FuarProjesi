using FuarProjesi.Models.ContextClasses;
using FuarProjesi.Models.Entities;
using FuarProjesi.Models.Hostesses.PageVms;
using FuarProjesi.Models.Hostesses.PureVms;
using FuarProjesi.Models.Hostesses.RequestModels;
using FuarProjesi.Models.Hostesses.ResponseModels;
using FuarProjesi.Models.MapperClasses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FuarProjesi.Controllers
{
    [Authorize(Roles ="Admin")]
    public class HostessController : Controller
    {
        MyContext _db;

        public HostessController(MyContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateHostess() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateHostess(CreateHostessRequestModel hostess)
        {
            Hostess h = new()
            {
                 FirstName = hostess.FirstName,
                 LastName = hostess.LastName,
                 Age = hostess.Age,
                 Languages = hostess.Languages

            };
            _db.Hostesses.Add(h);
            _db.SaveChanges();
            return RedirectToAction("GetHostesses");

        }
        public IActionResult GetHostesses()
        {
            List<HostessResponseModel> hostesses = _db.Hostesses.Select(x => new HostessResponseModel
            {
                ID = x.ID,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Age= x.Age,
                Languages = x.Languages 
            }).ToList();
            HostessResponsePageVM hTpvm = new HostessResponsePageVM
            {
                Hostesses = hostesses
            };


            return View(hTpvm);
        }
        public IActionResult UpdateHostess(int id)
        {
            HostessVM hostess = HostessMapper.GetHostessVM(_db.Hostesses.Find(id));

            HostessSharedPageVM hTpVm = new()
            {
                Hostess = hostess
            };


            return View(hTpVm);
        }

        [HttpPost]
        public IActionResult UpdateHostess(HostessVM hostess)
        {
            Hostess original = _db.Hostesses.Find(hostess.ID);
            original.FirstName = hostess.FirstName;
            original.LastName = hostess.LastName;
            original.Age = hostess.Age;
            original.Languages = hostess.Languages;

            _db.SaveChanges();
            TempData["message"] = "update successful";
            return RedirectToAction("GetHostesses");
        }
        public IActionResult DeleteHostess(int id)
        {
            _db.Hostesses.Remove(_db.Hostesses.Find(id));
            _db.SaveChanges();
            return RedirectToAction("GetHostesses");
        }
    }
}
