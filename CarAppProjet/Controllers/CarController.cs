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
            cbm.Value2 = c.Brands.ToList();
            return View(cbm);
        }
    }
}