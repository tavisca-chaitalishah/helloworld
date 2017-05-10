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
    public class EmployeeService : IEmployeeService
    {
        private IEmployeeManager _manager;

        public EmployeeService(IEmployeeManager manager)
        {
            _manager = manager;
        }
        public Employee Get(string employeeId)
        {
            try
            {
                var result = _manager.Get(employeeId);
                if (result == null) return null;
                return EmployeeTranslator.ToDataContract(result);
            }
            catch (Exception ex)
            {
                //var rethrow = ExceptionPolicy.HandleException("service.policy", ex);
                //if (rethrow) throw;
                throw ex;
            }
        }

        public DataContract.PagedList<Employee> GetEmployees(string pageSize, string pageNum, string orderBy, string isDescending)
        {
            try
            {
                var pagingInfo = PagingHelper.GetPagingInfo(pageSize, pageNum, orderBy, isDescending);

                var result = _manager.GetAll(pagingInfo.PageNumber, pagingInfo.PageSize, pagingInfo.OrderBy, pagingInfo.IsDescending);
                if (result == null) return null;
                return result.ToDataContract();
            }
            catch (Exception ex)
            {
                //var rethrow = ExceptionPolicy.HandleException("service.policy", ex);
                //if (rethrow) throw;
                //return null;
                throw ex;
            }

        }

        public DataContract.PagedList<Remark> GetRemarks(string employeeId, string pageSize, string pageNum, string orderBy, string isDescending)
        {
            try
            {
                var pagingInfo = PagingHelper.GetPagingInfo(pageSize, pageNum, orderBy, isDescending);

                var result = _manager.GetRemarks(employeeId, pagingInfo.PageNumber, pagingInfo.PageSize, pagingInfo.OrderBy, pagingInfo.IsDescending);
                if (result == null) return null;
                return result.ToDataContract();
            }
            catch (Exception ex)
            {
                //var rethrow = ExceptionPolicy.HandleException("service.policy", ex);
                //if (rethrow) throw;
                //return null;
                throw ex;
            }
        }
    }
}
