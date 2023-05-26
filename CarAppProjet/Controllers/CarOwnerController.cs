using CarAppProjet.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarAppProjet.Controllers
{
    public class CarOwnerController : Controller
    {
        Context ca = new Context();
        CarBrandModel cbm = new CarBrandModel();

        // GET: CarOwner
        public ActionResult CarOwnerIndex(CarOwner co)
        {
            cbm.ValueCar = ca.Cars.Where(x=>x.CarOwnerId==co.Id).ToList();
            return View(cbm);
        }

        // GET: CarOwner (araba ekleme)
        [HttpGet]
        public ActionResult NewCar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewCar(Car c)
        {
            ca.Cars.Add(c);
            ca.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: CarOwner (araba silme)
        public ActionResult DeleteCar(int id)
        {
            var findedCar = ca.Cars.Find(id);
            ca.Cars.Remove(findedCar);
            ca.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: CarOwner (araba güncelleme)
        public ActionResult GetCar(int id)
        {
            var findedCar2 = ca.Cars.Find(id);
            return View("GetCar", findedCar2);
        }
        public ActionResult UpdateCar(Car c)
        {
            var findedCar3 = ca.Cars.Find(c.ID);
            findedCar3.BrandID = c.BrandID;
            findedCar3.ModelId = c.ModelId;
            findedCar3.PhotoCarURL = c.PhotoCarURL;
            findedCar3.Year = c.Year;
            findedCar3.CarOwnerId = c.CarOwnerId;
            findedCar3.CarTypeId = c.CarTypeId;
            findedCar3.CityId = c.CityId;
            findedCar3.ColorId = c.ColorId;
            findedCar3.Description = c.Description;
            findedCar3.Doors = c.Doors;
            findedCar3.Engine = c.Engine;
            findedCar3.Mileage = c.Mileage;
            findedCar3.Price = c.Price;
            findedCar3.FuelType = c.FuelType;
            findedCar3.GearType = c.GearType;
            findedCar3.GlassCeiling = c.GlassCeiling;
            findedCar3.ParkingSensor = c.ParkingSensor;
            findedCar3.CentralLocking = c.CentralLocking;
            findedCar3.FoldableMirror = c.FoldableMirror;
            ca.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}