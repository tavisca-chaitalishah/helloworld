using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tavisca.EmployeeManagementWebApi.Services.DataContract;

namespace tavisca.EmployeeManagementWebApi.Services.ServiceContract
{
   public interface IEmployeeService
    {
        Employee Get(string employeeId);
        PagedList<Employee> GetEmployees(string pageSize, string pageNumber, string orderBy, string isDescending);

        PagedList<Remark> GetRemarks(string employeeId, string pageSize, string pageNumber, string orderBy, string isDescending);
    }
}
