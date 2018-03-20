using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecoWeb.Domain.Concrete;

namespace RecoWeb.Domain.Abstract
{
    public interface IMesEntityRepository
    {
        IEnumerable<COW_MenuListByJsonInquiry_Result> COW_MenuListByJsonInquiry();

        IEnumerable<PRW_EmployeeInquiry_Result> PRW_EmployeeInquiry(string category);
    }
}
