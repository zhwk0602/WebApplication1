﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Domain;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()


        {          
                var entity = new NorthwindEntities();
                var item = entity.Customers.ToList();
                     

            return View(item);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}