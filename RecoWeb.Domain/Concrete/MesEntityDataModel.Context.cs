﻿//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 템플릿에서 생성되었습니다.
//
//     이 파일을 수동으로 변경하면 응용 프로그램에서 예기치 않은 동작이 발생할 수 있습니다.
//     이 파일을 수동으로 변경하면 코드가 다시 생성될 때 변경 내용을 덮어씁니다.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RecoWeb.Domain.Concrete
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<COW_MenuInquiry_Result> COW_MenuInquiry(string p_Category)
        {
            var p_CategoryParameter = p_Category != null ?
                new ObjectParameter("p_Category", p_Category) :
                new ObjectParameter("p_Category", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<COW_MenuInquiry_Result>("COW_MenuInquiry", p_CategoryParameter);
        }
    
        public virtual ObjectResult<COW_MenuInquiry2_Result> COW_MenuInquiry2(string p_Category)
        {
            var p_CategoryParameter = p_Category != null ?
                new ObjectParameter("p_Category", p_Category) :
                new ObjectParameter("p_Category", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<COW_MenuInquiry2_Result>("COW_MenuInquiry2", p_CategoryParameter);
        }
    }
}
