using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using tavisca.EmployeeManagementWebApi.BusinessLayer.Interface;
using tavisca.EmployeeManagementWebApi.BusinessLayer.Model;

namespace tavisca.EmployeeManagementWebApi.BusinessLayer.BusinessLogic
{
    public class EmployeeManager : IEmployeeManager
    {
        public EmployeeManager(IEmployeeStorage storage, IRemarkStorage remarkStorage)
        {
            _storage = storage;
            _remarkStorage = remarkStorage;
        }

       private IEmployeeStorage _storage;
        private IRemarkStorage _remarkStorage;

        public Employee Get(string employeeId)
        {
            return _storage.GetByID(employeeId);
        }

        public PagedList<Employee> GetAll(int pageNumber = 1, int pageSize = 20, string orderBy = "Id", SortingOrder sortingOrder = SortingOrder.DESC)
        {
            throw new NotImplementedException();
        }

        public PagedList<Remark> GetRemarks(string employeeId, int pageNumber = 1, int pageSize = 20, string orderBy = "Id", SortingOrder sortingOrder = SortingOrder.DESC)
        {
            return _remarkStorage.GetRemarks(employeeId, pageNumber, pageSize, orderBy, sortingOrder);
        }
    }
}