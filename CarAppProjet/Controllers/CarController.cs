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
            cbm.Value1 = c.Cars.ToList();
            cbm.Value2 = c.Brands.ToList();
            cbm.Value3 = c.Models.ToList();
            return View(cbm);
        }

        public ActionResult CarDetail(int id)
        {

            cbm.Value2 = c.Brands.ToList();
            cbm.Value3 = c.Models.ToList();
            return View(cbm);
        }
    }
}