using CarAppProjet.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarAppProjet.Controllers
{
    public class CarController : Controller
    {
        // GET: Car
        Context c = new Context();
        CarBrandModel cbm = new CarBrandModel();

        public ActionResult CarIndex()
        {
            cbm.ValueCar = c.Cars.ToList();
            cbm.ValueBrand = c.Brands.ToList();
            cbm.ValueModel = c.Models.ToList();
            cbm.ValueColor = c.Colors.ToList();
            cbm.ValueCarOwner = c.CarOwners.ToList();
            cbm.ValueCarType = c.CarTypes.ToList();
            return View(cbm);
        }

        public ActionResult CarDetail(int id)
        {
            cbm.ValueCar  = c.Cars.Where(a => a.ID == id).ToList();
            cbm.ValueCarOwner = c.CarOwners.ToList();
            cbm.ValueBrand = c.Brands.Where(a => a.Id == id).ToList();
            cbm.ValueModel = c.Models.Where(a => a.Brand.Id== id).Take(1).ToList();
            cbm.ValueColor = c.Colors.ToList();
            cbm.ValueCarType = c.CarTypes.Where(a => a.Id == id).ToList();

            return View(cbm);
        }
    }
}