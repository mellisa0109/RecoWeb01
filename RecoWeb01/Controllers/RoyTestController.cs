using DevExpress.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RecoWeb01.Controllers
{
    public class RoyTestController : Controller
    {
        // GET: RoyTest
        public ActionResult Index()
        {
            return View();
        }

        [ValidateInput(false)]
        public ActionResult RoyTestGridViewPatial()
        {
            var model = new object[0];
            return PartialView("_RoyTestGridViewPatial", model);
        }
    }
}