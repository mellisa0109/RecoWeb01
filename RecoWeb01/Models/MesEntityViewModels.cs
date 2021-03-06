﻿using RecoWeb.Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RecoWeb01.Models
{
    public class COW_MenuInquiryViewModel
    {
        public IEnumerable<COW_MenuListByJsonInquiry_Result> COW_MenuListByJsonInquiryMainMenu { get; set; }

        public IEnumerable<COW_MenuListByJsonInquiry_Result> COW_MenuListByJsonInquirySubMenu { get; set; }
    }
    
    public class PRW_EmployeeSaveViewModel
    {
        public int PRW_EmployeeSave { get; set; }
    }

    public class COW_DataStackInquiryViewModel
    {
        public IEnumerable<COW_DataStackInquiry_Result> COW_DataStackInquiry { get; set; }
    }
}