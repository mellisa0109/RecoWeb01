using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecoWeb.Domain.Concrete;
using System.Data.Entity.Core.Objects;

namespace RecoWeb.Domain.Abstract
{
    public interface IMesEntityRepository
    {
        IEnumerable<COW_MenuInquiry_Result> COW_MenuInquiry(string category);

        IEnumerable<string> EmployeeAdd(string id, string password, string name, string email, string phonenumber, ObjectParameter outmessage);
            
    }
}
