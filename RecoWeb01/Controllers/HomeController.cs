using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RecoWeb.Domain.Abstract;
using RecoWeb01.Models;
using RecoWeb.Domain.Concrete;

namespace RecoWeb01.Controllers
{
    public class HomeController : Controller
    {
        private IMesEntityRepository repository;

        public HomeController(IMesEntityRepository repositoryParam)
        {
            this.repository = repositoryParam;
        }

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



        public ViewResult MenuList()
        {

            COW_MenuInquiryViewModel viewModel = new COW_MenuInquiryViewModel
            {
                //COW_MenuInquiry = repository.COW_MenuInquiry("Menu")
            };
            return View(viewModel);
        }
    }
}