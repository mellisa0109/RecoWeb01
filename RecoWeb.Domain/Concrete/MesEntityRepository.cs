using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecoWeb.Domain.Abstract;
using System.Data.Entity.Core.Objects;

namespace RecoWeb.Domain.Concrete
{
    public class MesEntityRepository : IMesEntityRepository
    {
        private Entities context = new Entities();     

        public IEnumerable<COW_MenuInquiry_Result> COW_MenuInquiry(string category){
            return context.COW_MenuInquiry(category); 
        }
        

        public IEnumerable<string> EmployeeAdd(string id,string password, string name, string email, string phonenumber, ObjectParameter outmessage)
        {
            return context.COW_EmployeeSave(id, password, name, email, phonenumber, outmessage);
        }
    }
}
