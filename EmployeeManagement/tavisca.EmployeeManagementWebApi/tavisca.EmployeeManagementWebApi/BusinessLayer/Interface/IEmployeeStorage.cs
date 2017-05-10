using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tavisca.EmployeeManagementWebApi.BusinessLayer.Model;

namespace tavisca.EmployeeManagementWebApi.BusinessLayer.Interface
{
   public interface IEmployeeStorage
    {
        Employee Save(Employee employee);

        Employee GetByID(string employeeId);

        List<Employee> GetAll();
        PagedList<Employee> GetEmployees(int pageNumber = 1, int pageSize = 20, string orderBy = "Id", SortingOrder sortingOrder = SortingOrder.DESC);

        Employee GetByEmail(string email);
    }
}
