using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using CarAppProjet.Models.Classes;

namespace CarAppProjet.Controllers
{
    public class HomeController : Controller
    {
        Context c = new Context();
        CarBrandModel cbm = new CarBrandModel();
        public ActionResult HomeIndex()
        {
            cbm.ValueCar = c.Cars.ToList().Take(3);
            cbm.ValueBrand = c.Brands.ToList();
            cbm.ValueAbout = c.Abouts.ToList();
            cbm.ValueComment = c.Comments.ToList().Take(6);
            var car = cbm.ValueBrand.FirstOrDefault();

            if (car != null)
            {
                var Id = car.ID; // Get the brandId from the car object

                var modelsByBrand = c.Models
                    .Include(i => i.Brand)
                    .Where(m => m.Brand.ID == Id)
                    .ToList();

                cbm.ValueModel = modelsByBrand;
            }
            else
            {
                cbm.ValueModel = new List<Model>(); // Or set it to an empty list if the car is not found
            }

            return View(cbm);
        }

    }
}