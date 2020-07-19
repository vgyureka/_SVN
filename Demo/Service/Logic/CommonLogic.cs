using Demo.Shared.Models;
using Service.Data.SCHEMA_NAME;
using System;
using System.Collections.Generic;
using System.Data;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Service.Logic
{
    public class CommonLogic
    {
        public static AuthenticateResult Authenticate(string environment="DEV")
        {
            var result = new AuthenticateResult();
           
            result.Environment = environment;
            string fullName = Environment.UserName;
            var domainName = Environment.UserDomainName;
           // var fullName = ServiceSecurityContext.Current.WindowsIdentity.Name;
         
            //using (var pctx = new PrincipalContext(ContextType.Domain))
            //{
            //    using (UserPrincipal up = UserPrincipal.FindByIdentity(pctx,fullName))
            //    {
            //        if (up != null && !string.IsNullOrEmpty(up.EmailAddress))
            //            result.EmailAddress = up.EmailAddress;
            //    }
            //}

            var userName = fullName.Split('\\').Last();
            result.FullName = fullName;
            result.UserName = userName;
            DataTable dt;
            //   PKG_NAME.GetLoginAuth(userName.ToUpper(),out dt);
            // result.Authenticated = dt.Rows.Count != 0;
            result.Authenticated = true;

         //   if (!result.Authenticated)
            return result;


              
        }



    }
}
