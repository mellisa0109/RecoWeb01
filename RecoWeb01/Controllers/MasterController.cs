using RecoWeb.Domain.Abstract;
using RecoWeb01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RecoWeb01.Controllers
{
    public class MasterController : Controller
    {
        IMesEntityRepository repository;
        public MasterController(IMesEntityRepository repositoryParam)
        {
            repository = repositoryParam;
        }

        // GET: Master
        public ActionResult Employee()
        {
            COW_MenuInquiryViewModel viewModel = new COW_MenuInquiryViewModel
            {
                
            };

            return View(viewModel);
        }

        //public ActionResult myTest()
        //{
        //    COW_MenuInquiryViewModel viewModel = new COW_MenuInquiryViewModel
        //    {
        //        COW_MenuInquiry = repository.COW_MenuInquiry("Menu")
        //    };
        //    return View(viewModel);
        //}
    }
}