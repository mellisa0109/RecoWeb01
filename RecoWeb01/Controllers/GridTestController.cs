using DevExpress.Web.Mvc;
using RecoWeb.Domain.Abstract;
using RecoWeb01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RecoWeb01.Controllers
{
    public class GridTestController : Controller
    {
        IMesEntityRepository repository;
        public GridTestController(IMesEntityRepository repositoryParam)
        {
            repository = repositoryParam;
        }
        public ActionResult Index()
        {
            COW_DataStackInquiryViewModel viewModel = new COW_DataStackInquiryViewModel
            {
                //COW_MenuInquiry = repository.COW_MenuInquiry("Menu")
            };
            return View(viewModel);
        }

        public ViewResult GridTest(string code)
        {
            COW_DataStackInquiryViewModel viewModel = new COW_DataStackInquiryViewModel
            {
                COW_DataStackInquiry = repository.COW_DataStackInquiry(code).ToList()
            };

            return View(viewModel);
        }
        


        [ValidateInput(false)]
        public ActionResult Grid_DataStack()
        {
            COW_DataStackInquiryViewModel viewModel = new COW_DataStackInquiryViewModel
            {
                COW_DataStackInquiry = repository.COW_DataStackInquiry("").ToList()
            };

            return PartialView("_Grid_DataStack", viewModel.COW_DataStackInquiry);
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult Grid_DataStackAddNew([ModelBinder(typeof(DevExpressEditorsBinder))] RecoWeb01.Models.COW_DataStackInquiryViewModel item)
        {
            var model = new object[0];
            if (ModelState.IsValid)
            {
                try
                {
                    // Insert here a code to insert the new item in your model
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            else
                ViewData["EditError"] = "Please, correct all errors.";
            return PartialView("_Grid_DataStack", model);
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult Grid_DataStackUpdate([ModelBinder(typeof(DevExpressEditorsBinder))] RecoWeb01.Models.COW_DataStackInquiryViewModel item)
        {
            var model = new object[0];
            if (ModelState.IsValid)
            {
                try
                {
                    // Insert here a code to update the item in your model
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            else
                ViewData["EditError"] = "Please, correct all errors.";
            return PartialView("_Grid_DataStack", model);
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult Grid_DataStackDelete(RecoWeb.Domain.Concrete.COW_DataStackInquiry_Result COW_DataStackInquiry)
        {
            var model = new object[0];
            if (COW_DataStackInquiry != null)
            {
                try
                {
                    // Insert here a code to delete the item from your model
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            return PartialView("_Grid_DataStack", model);
        }
        

    }
}