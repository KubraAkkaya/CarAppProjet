using CarAppProjet.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace CarAppProjet.Controllers
{
    public class CarController : Controller
    {
        // GET: Car
        Context c = new Context();
        CarBrandModel cbm = new CarBrandModel();

        public ActionResult CarIndex()
        {
            cbm.ValueCar = c.Cars.Include(i=>i.Brand).Include(i=>i.Model).ToList();
            //cbm.ValueBrand = c.Brands.ToList();
            var car = cbm.ValueBrand.FirstOrDefault(); //seçildiğinde

            if (car != null)
            {
                var Id = car.Id; // Get the brandId from the car object

                var modelsByBrand = c.Models
                    .Include(i => i.Brand)
                    .Where(m => m.Brand.Id == Id)
                    .ToList();

                cbm.ValueModel = modelsByBrand;
            }
            else
            {
                cbm.ValueModel = new List<Model>(); // Or set it to an empty list if the car is not found
            }

            //cbm.ValueModel = c.Models.ToList();
            cbm.ValueColor = c.Colors.ToList();
            cbm.ValueCarOwner = c.CarOwners.ToList();
            cbm.ValueCarType = c.CarTypes.ToList();
            return View(cbm);
        }

        public ActionResult CarDetail(int id)
        {
            cbm.ValueCar = c.Cars.Where(a => a.ID == id)
                .Include(i => i.Brand)
                .Include(i => i.Model)
                .Include(i => i.Color)
                .Include(i => i.CarOwner)
                .Include(i => i.CarType).ToList();

            cbm.ValueComment = c.Comments.Where(a => a.CarId == id).ToList();
            //cbm.ValueCarOwner = c.CarOwners.ToList();
            //cbm.ValueBrand = c.Brands.Where(a => a.Id == id).ToList();
            var car = cbm.ValueCar.FirstOrDefault();

            if (car != null)
            {
                var Id = car.Brand.Id; // Get the brandId from the car object

                var modelsByBrand = c.Models
                    .Include(i => i.Brand)
                    .Where(m => m.Brand.Id == Id)
                    .ToList();

                cbm.ValueModel = modelsByBrand;
            }
            else
            {
                cbm.ValueModel = new List<Model>(); // Or set it to an empty list if the car is not found
            }
            //cbm.ValueModel = c.Models.Include(i=>i.Brand).ToList();
            //cbm.ValueColor = c.Colors.ToList();
            //cbm.ValueCarType = c.CarTypes.Where(a => a.Id == id).ToList();

            return View(cbm);
        }
    }
}