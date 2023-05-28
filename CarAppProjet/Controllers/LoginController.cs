﻿using CarAppProjet.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace CarAppProjet.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin Login
        Context c=new Context();

        public ActionResult LoginIndex()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoginIndex(Admin ad)
        {
            var info = c.Admins.FirstOrDefault(x => x.AdminName == ad.AdminName && x.Password == ad.Password);
            if (info != null)
            {
                FormsAuthentication.SetAuthCookie(info.AdminName, false);
                Session["AdminName"] = info.AdminName.ToString();
                return RedirectToAction("AdminIndex", "Admin");

            }else
                return View();
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("LoginIndex", "Login");
        }


        // GET: CarOwner Login
        public ActionResult LoginCarOwner()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoginCarOwner(CarOwner ad)
        {
            var info = c.CarOwners.FirstOrDefault(x => x.LastName == ad.LastName && x.Password == ad.Password);
            if (info != null)
            {
                FormsAuthentication.SetAuthCookie(info.LastName, false);
                Session["LastName"] = info.LastName.ToString();
                return RedirectToAction("CarOwnerIndex", "CarOwner");

            }
            else
            {
                return View();
            }
  
        }

        public ActionResult LogOutCarOwner()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("LoginCarOwner", "Login");
        }


        // GET: Customer Login
        public ActionResult CustomerLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CustomerLogin(Customer ad)
        {

            var info = c.Customers.FirstOrDefault(x => x.Mail == ad.Mail && x.Password == ad.Password);
            if (info != null)
            {
                FormsAuthentication.SetAuthCookie(info.Mail, false);
                Session["Mail"] = info.Mail.ToString();
                return RedirectToAction("HomeIndex", "Home");

            }
            else
            {
                return View();
            }

        }
    }
}