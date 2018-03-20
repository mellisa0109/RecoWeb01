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
    public class EmployeesController : Controller
    {
        IMesEntityRepository repository;
        public EmployeesController(IMesEntityRepository repositoryParam)
        {
            repository = repositoryParam;
        }
        
        // GET: Grid
        public ActionResult index()
        {
            PRW_EmployeeInquiryViewModel viewModel = new PRW_EmployeeInquiryViewModel
            {
                PRW_EmployeeInquiry = repository.PRW_EmployeeInquiry("1100")
            };
            return View(viewModel);
        }

        [ValidateInput(false)]
        public ActionResult GridView1Partial()
        {
            //var model = new object[0];
            return PartialView("_GridView1Partial", repository.PRW_EmployeeInquiry("1100"));
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult GridView1PartialAddNew([ModelBinder(typeof(DevExpressEditorsBinder))] RecoWeb.Domain.Concrete.PRW_EmployeeInquiry_Result item)
        {
            //var model = new object[0];
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
            return PartialView("_GridView1Partial", repository.PRW_EmployeeInquiry("1100"));
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult GridView1PartialUpdate([ModelBinder(typeof(DevExpressEditorsBinder))] RecoWeb.Domain.Concrete.PRW_EmployeeInquiry_Result item)
        {
            //var model = new object[0];
            if (ModelState.IsValid)
            {
                try
                {
                    //repository.PRW_EmployeeSave(item.EmployeeId, item.EmployeeName, item.Gubun, item.)
                    // Insert here a code to update the item in your model
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            else
                ViewData["EditError"] = "Please, correct all errors.";
            return PartialView("_GridView1Partial", repository.PRW_EmployeeInquiry("1100"));
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult GridView1PartialDelete(System.String EmployeeId)
        {
            //var model = new object[0];
            if (EmployeeId != null)
            {
                try
                {
                    //repository.PRW_EmployeeDelete(EmployeeId);
                    // Insert here a code to delete the item from your model
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            return PartialView("_GridView1Partial", repository.PRW_EmployeeInquiry("1100"));
        }
    }
}