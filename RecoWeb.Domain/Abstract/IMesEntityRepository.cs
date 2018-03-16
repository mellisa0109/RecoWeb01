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
        IEnumerable<COW_MenuInquiry_Result> COW_MenuInquiry(string category);

        IEnumerable<TPREmployees> TPREmployeesAdd();
    }
}
