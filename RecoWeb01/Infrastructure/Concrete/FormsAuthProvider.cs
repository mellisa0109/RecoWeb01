using RecoWeb.Domain.Abstract;
using RecoWeb01.Infrastructure.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace RecoWeb01.Infrastructure.Concrete
{
    public class FormsAuthProvider : IAuthProvider
    {
        IMesEntityRepository repository;

        public FormsAuthProvider(IMesEntityRepository repositoryParam)
        {
            repository = repositoryParam;
        }

        public bool Authenticate(string username, string password)
        {

            bool result = CheckAuthenticate(username, password);
            if (result)
            {
                FormsAuthentication.SetAuthCookie(username, false);
            }
            return result;
        }

        public bool CheckAuthenticate(string username, string password)
        {
            ObjectParameter p_OutResult = new ObjectParameter("p_OutResult", typeof(string));
            ObjectParameter p_OutMessage = new ObjectParameter("p_OutMessage", typeof(string));
            repository.COW_AuthenticateInquiry(username, password, p_OutResult, p_OutMessage);
            return (bool)p_OutResult.Value;
        }
    }
}