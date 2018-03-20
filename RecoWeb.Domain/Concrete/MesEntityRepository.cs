using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecoWeb.Domain.Abstract;

namespace RecoWeb.Domain.Concrete
{
    public class MesEntityRepository : IMesEntityRepository
    {
        private RecowebdbEntities context = new RecowebdbEntities();    
         

        public IEnumerable<COW_MenuListByJsonInquiry_Result> COW_MenuListByJsonInquiry(){
            return context.COW_MenuListByJsonInquiry();
        }

        public IEnumerable<PRW_EmployeeInquiry_Result> PRW_EmployeeInquiry(string category)
        {
            return context.PRW_EmployeeInquiry(category);
        }
    }
}
