﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SeasonApp.Models;

namespace SeasonApp.Controllers
{
    public class SeasonController : Controller
    {
        // GET: /Season/Index
        // GET: /Season
        public ActionResult Index()
        {
            return View();
        }

        // POST: /Season/Show
        // Acquire information about the season and send it to Show.cshtml
        [HttpPost]
        public ActionResult Show(int? temperature)
        {
            //we will to gather the season information from the temperature provided
            SeasonAPIController controller = new SeasonAPIController();
            Season SeasonInfo = controller.GetSeason(temperature);               
            return View(SeasonInfo);
        }
      
    }
}