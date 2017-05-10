using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using tavisca.EmployeeManagementWebApi.BusinessLayer.Interface;
using tavisca.EmployeeManagementWebApi.Services.DataContract;
using tavisca.EmployeeManagementWebApi.Services.ServiceContract;
using tavisca.EmployeeManagementWebApi.Services.Translator;

namespace tavisca.EmployeeManagementWebApi.Services.ServiceImplementation
{
    public class EmployeeManagementService : IEmployeeManagementService
    {
        private IEmployeeManagementManager _manager;
        

        public EmployeeManagementService(IEmployeeManagementManager manager)
        {
            _manager = manager;
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
                //var rethrow = ExceptionPolicy.HandleException("service.policy", ex, out newEx);
                //throw newEx;
                throw ex;
            }
        }

       
        public Employee Create(Employee employee)
        {
            try
            {
                var result = _manager.Create(EmployeeTranslator.ToDomainModel(employee));
                if (result == null) return null;
                return result.ToDataContract();
            }
            catch (Exception ex)
            {
                //Exception newEx;
                //var rethrow = ExceptionPolicy.HandleException("service.policy", ex, out newEx);
                //throw newEx;
                throw ex;
            }
        }
    }
}