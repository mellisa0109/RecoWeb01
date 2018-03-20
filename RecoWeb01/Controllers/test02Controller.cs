using RecoWeb.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RecoWeb01.Models;

namespace RecoWeb01.Controllers
{
    public class test02Controller : Controller
    {
        IMesEntityRepository repository;
        public test02Controller(IMesEntityRepository repositoryParam)
        {
            repository = repositoryParam;
        }


        // GET: test02
        public ActionResult Index()
        {
            COW_MenuInquiryViewModel viewModel = new COW_MenuInquiryViewModel
            {
                COW_MenuInquiry = repository.COW_MenuInquiry("Menu")
            };
            return View(viewModel);
        }
    }
}