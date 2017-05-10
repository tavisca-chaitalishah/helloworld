using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tavisca.EmployeeManagementWebApi.Services.DataContract;

namespace tavisca.EmployeeManagementWebApi.Services.ServiceContract
{
  
    public interface IIdentityService
    {
       
        Employee Authenticate(Credential credential);
        
        bool ChangePassword(ChangePasswordRequest request);
    }
}
