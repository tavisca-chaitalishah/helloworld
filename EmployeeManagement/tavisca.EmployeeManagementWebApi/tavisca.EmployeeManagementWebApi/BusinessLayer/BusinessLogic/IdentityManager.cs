using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using tavisca.EmployeeManagementWebApi.BusinessLayer.Interface;
using tavisca.EmployeeManagementWebApi.BusinessLayer.Model;

namespace tavisca.EmployeeManagementWebApi.BusinessLayer.BusinessLogic
{
    public class IdentityManager : IIdentityManager
    {
        private IEmployeeStorage _storage;
        public IdentityManager(IEmployeeStorage storage)
        {
            _storage = storage;
        }


        public Employee Authenticate(Credential credential)
        {
            var employee = _storage.GetByEmail(credential.Email);
            if (employee == null)
                throw new Exception("Invalid email.");
            // check if password matches
            if (credential.Password.Equals(employee.Password))
                return employee;
            else
                throw new Exception("Invalid password.");
        }

        public bool ChangePassword(string email, string oldPassword, string newPassword)
        {
            var employee = _storage.GetByEmail(email);
            if (employee == null)
                throw new Exception("Invalid email.");

            // update password
            if (oldPassword.Equals(employee.Password))
            {
                employee.Password = newPassword;
                _storage.Save(employee);
                return true;
            }
            else
                return false;
        }
    }
}