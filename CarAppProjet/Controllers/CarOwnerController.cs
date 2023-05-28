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
            cbm.ValueCar = ca.Cars.Where(x=>x.CarOwner.ID==co.ID).ToList();
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
            findedCar3.Brand.ID = c.Brand.ID;
            findedCar3.Model.ID = c.Model.ID;
            findedCar3.PhotoCarURL = c.PhotoCarURL;
            findedCar3.Year = c.Year;
            findedCar3.CarOwner.ID = c.CarOwner.ID;
            findedCar3.CarType.ID = c.CarType.ID;
            findedCar3.City.ID = c.City.ID;
            findedCar3.Color.ID = c.Color.ID;
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