﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SIGEM_TAEX.Controllers
{
    public class WebController : Controller
    {
        // GET: Web
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Conocenos()
        {
            return View();
        }

        public ActionResult Talleres()
        {
            return View();
        }

        public ActionResult VerTaller()
        {
            return View();
        }
    }
}