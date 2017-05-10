using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using tavisca.EmployeeManagementWebApi.BusinessLayer.Interface;
using tavisca.EmployeeManagementWebApi.BusinessLayer.Model;

namespace tavisca.EmployeeManagementWebApi.BusinessLayer.BusinessLogic
{
    public class EmployeeManagementManager : IEmployeeManagementManager
    {
        private IEmployeeStorage _storage;
        IRemarkStorage _remarkStorage;

        public EmployeeManagementManager(IEmployeeStorage storage, IRemarkStorage remarkStorage)
        {
            _storage = storage;
            _remarkStorage = remarkStorage;
        }

        public Remark AddRemark(string employeeId, Remark remark)
        {
            remark.Validate();
            remark.CreateTimeStamp = DateTime.UtcNow;
            return _remarkStorage.AddRemark(employeeId, remark);
        }

        Employee IEmployeeManagementManager.Create(Employee employee)
        {
            employee.Validate();
            employee.Id = Guid.NewGuid().ToString();
            employee.Password = "p@ssw0rd";
                return _storage.Save(employee);
           
        }

       
    }
}