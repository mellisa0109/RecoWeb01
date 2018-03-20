using RecoWeb.Domain.Abstract;
using RecoWeb01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace RecoWeb01.Controllers
{
    public class MenuController : Controller
    {
        IMesEntityRepository repository;
        public MenuController(IMesEntityRepository repositoryParam)
        {
            repository = repositoryParam;
        }

        // GET: Menu
        public ActionResult Index()
        {
            COW_MenuInquiryViewModel viewModel = new COW_MenuInquiryViewModel
            {
                //COW_MenuInquiry = repository.COW_MenuInquiry("Menu")
            };
            return View(viewModel);
        }

        public ViewResult MenuList()
        {
            COW_MenuInquiryViewModel viewModel = new COW_MenuInquiryViewModel
            {
                COW_MenuListByJsonInquiryMainMenu = repository.COW_MenuListByJsonInquiry().Where(s => s.MenuCode == "Root").ToList()
                ,COW_MenuListByJsonInquirySubMenu = repository.COW_MenuListByJsonInquiry().Where(s => s.MenuCode == repository.COW_MenuListByJsonInquiry().Where(m => m.MenuCode == "Root").FirstOrDefault().ParentMenuCode).ToList()
            };

            return View(viewModel);
        }

        public ViewResult ChagingSubMenu(string subMenu)
        {
            COW_MenuInquiryViewModel viewModel = new COW_MenuInquiryViewModel
            {
                COW_MenuListByJsonInquirySubMenu = repository.COW_MenuListByJsonInquiry().Where(s => s.MenuCode == subMenu).ToList()
            };

            return View(viewModel);
        }

    }
}