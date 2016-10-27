﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeatherApp.Models;

namespace WeatherApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult WeatherJS()
        {
            return View();
        }
        public ActionResult WeatherOrNot()
        {
            return View();
        }
        public JsonResult GetWeather()
        {
            WeatherClass weath = new WeatherClass();
            return Json(weath.getWeatherForecast(),JsonRequestBehavior.AllowGet);
        }
    }
}