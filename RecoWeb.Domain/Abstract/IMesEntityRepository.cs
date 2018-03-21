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
        IEnumerable<COW_MenuListByJsonInquiry_Result> COW_MenuListByJsonInquiry();

        int PRW_EmployeeSave(string id, string password, string name, string email, string phonenumber, ObjectParameter outmessage);

        IEnumerable<COW_DataStackInquiry_Result> COW_DataStackInquiry(string code);
    }
}
