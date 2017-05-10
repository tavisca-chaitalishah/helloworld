using DataContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceContract
{
    public interface IIdentityService
    {
        [WebInvoke(Method = "POST", UriTemplate = "authenticate", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        Employee Authenticate(Credential credential);

        [WebInvoke(Method = "POST", UriTemplate = "changePassword", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        bool ChangePassword(ChangePasswordRequest request);
    }
}
