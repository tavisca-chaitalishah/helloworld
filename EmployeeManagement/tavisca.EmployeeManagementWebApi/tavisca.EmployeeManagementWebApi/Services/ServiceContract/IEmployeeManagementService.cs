using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tavisca.EmployeeManagementWebApi.Services.DataContract;

namespace tavisca.EmployeeManagementWebApi.Services.ServiceContract
{
    public interface IEmployeeManagementService
    {
        Employee Create(Employee employee);
        Remark AddRemark(string employeeId, Remark remark);
    }
}
