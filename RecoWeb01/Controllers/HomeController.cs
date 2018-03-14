﻿using RecoWeb01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace RecoWeb01.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        [HttpPost]
        public ActionResult Index(DbModels model)
        {
            if (ModelState.IsValid)// 모델에 선언됨 Required를 체크 하여 True,false 인지 파악
            {
                model.SpValueList = null;
                model.SpOutput = "";
                model.SpValueJson = GetDateTimeAsync();
            }
            
            return View(model);
        }

        private string GetDateTimeAsync()
        {
            ServiceReference.ServiceClient service = new ServiceReference.ServiceClient();
            return service.GetDateTime();
        }
    }
}