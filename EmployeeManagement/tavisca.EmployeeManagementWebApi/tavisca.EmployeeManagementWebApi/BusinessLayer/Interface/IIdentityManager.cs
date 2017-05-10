using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tavisca.EmployeeManagementWebApi.BusinessLayer.Model;

namespace tavisca.EmployeeManagementWebApi.BusinessLayer.Interface
{
    public interface IIdentityManager
    {
        Employee Authenticate(Credential credential);

        bool ChangePassword(string email, string oldPassword, string newPassword);
    }
}
