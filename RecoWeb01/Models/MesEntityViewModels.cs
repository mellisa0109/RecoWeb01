using RecoWeb.Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RecoWeb01.Models
{
    public class COW_MenuInquiryViewModel
    {
        public IEnumerable<COW_MenuListByJsonInquiry_Result> COW_MenuListByJsonInquiry { get; set; }        
    }

    public class PRW_EmployeeInquiryViewModel
    {
        public IEnumerable<PRW_EmployeeInquiry_Result> PRW_EmployeeInquiry { get; set; }
    }
}