using RecoWeb.Domain.Abstract;
using RecoWeb01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RecoWeb01.Controllers
{
    public class test01Controller : Controller
    {
        IMesEntityRepository repository;
        public test01Controller(IMesEntityRepository repositoryParam)
        {
            repository = repositoryParam;
        }

        // GET: test01
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