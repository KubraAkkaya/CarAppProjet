using CarAppProjet.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarAppProjet.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        Context c = new Context();
        CarBrandModel cbm = new CarBrandModel();
        public ActionResult AboutIndex()
        {
            var degerler = c.Abouts.ToList();
            return View(degerler);
        }
        public ActionResult AboutDetail(int id)
        {
            var d = c.Abouts.Where(a => a.ID == id).ToList();
            return View(d);
        }
    }
}