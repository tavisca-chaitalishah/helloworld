using DataContract;
using Interface;
using ServiceContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceImplementation
{
    public class EmployeeService : IEmployeeService
    {
        public EmployeeService(IEmployeeManager manager)
        {
            _manager = manager;
        }

        IEmployeeManager _manager;

        public Employee Get(string employeeId)
        {
            try
            {
                var result = _manager.Get(employeeId);
                if (result == null) return null;
                return result.ToDataContract();
            }
            catch (Exception ex)
            {
                var rethrow = ExceptionPolicy.HandleException("service.policy", ex);
                if (rethrow) throw;
                return null;
            }
        }

        public DataContract.PagedList<DataContract.Employee> GetEmployees(string pageSize, string pageNum, string orderBy, string isDescending)
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
                var rethrow = ExceptionPolicy.HandleException("service.policy", ex);
                if (rethrow) throw;
                return null;
            }

        }

        public DataContract.PagedList<DataContract.Remark> GetRemarks(string employeeId, string pageSize, string pageNum, string orderBy, string isDescending)
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
                var rethrow = ExceptionPolicy.HandleException("service.policy", ex);
                if (rethrow) throw;
                return null;
            }
        }
    }
}
