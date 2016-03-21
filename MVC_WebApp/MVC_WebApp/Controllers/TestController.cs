﻿using MVC_WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_WebApp.Controllers
{
    public class TestController : Controller
    {

        public string MyFirstMethod()
        {
            return "Welcome to QuestPond!!!";
        }

        public ActionResult MyFirstView()
        {
            CustomerBAL b = new CustomerBAL();
            Customer c = b.GetCustomer();
            ViewBag.CustomerData = c;

            //string CustomerName = "Mr. ABC";
            //ViewData["MyData"] = CustomerName;
            ////ViewBag.MyData = CustomerName;
            //return View("MyFirstView");

            return View();
        }

    }
}