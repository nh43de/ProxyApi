﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProxyApi.Sample.Models;

namespace ProxyApi.Sample.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

        
        [ProxyApi.Documentation("This is my demo documentation to prove it works")]
		public ActionResult OtherPage()
		{
			return PartialView();
		}

		public ActionResult NoAntiForgeryToken()
		{
			return View();
		}
	}
}
