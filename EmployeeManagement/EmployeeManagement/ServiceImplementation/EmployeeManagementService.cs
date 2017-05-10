using DataContract;
using Interface;
using ServiceContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Translator;

namespace ServiceImplementation
{
    public class EmployeeManagementService : IEmployeeManagementService
    {
        public EmployeeManagementService(IEmployeeManagementManager manager)
        {
            _manager = manager;
        }

        IEmployeeManagementManager _manager;

        public Employee Create(Employee employee)
        {
            try
            {
                var result = _manager.Create(employee.ToDomainModel());
                if (result == null) return null;
                return result.ToDataContract();
            }
            catch (Exception ex)
            {
                // Exception newEx;
                //  var rethrow = ExceptionPolicy.HandleException("service.policy", ex, out newEx);
                //  throw newEx;
            }
        }

        public Remark AddRemark(string employeeId, Remark remark)
        {
            try
            {
                var result = _manager.AddRemark(employeeId, remark.ToDomainModel());
                if (result == null) return null;
                return result.ToDataContract();
            }
            catch (Exception ex)
            {
                //Exception newEx;
                //  var rethrow = ExceptionPolicy.HandleException("service.policy", ex, out newEx);
                //  throw newEx;
            }
        }
    }
}
