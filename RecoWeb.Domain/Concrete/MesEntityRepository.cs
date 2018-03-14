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
        private Entities context = new Entities();     

        public IEnumerable<COW_MenuInquiry_Result> COW_MenuInquiry(string category){
            return context.COW_MenuInquiry(category);
        }
    }
}
