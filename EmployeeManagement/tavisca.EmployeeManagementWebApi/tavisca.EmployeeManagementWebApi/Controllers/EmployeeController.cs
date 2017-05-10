using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using tavisca.EmployeeManagementWebApi.BusinessLayer.Interface;
using tavisca.EmployeeManagementWebApi.BusinessLayer.Model;
using tavisca.EmployeeManagementWebApi.DataAccess;

namespace tavisca.EmployeeManagementWebApi.Controllers
{

    [RoutePrefix("api/employee")]
    public class EmployeeController : ApiController
    {
        private IEmployeeStorage _employeeStore;

        public EmployeeController()
        {
            _employeeStore = new EmployeeStorage();
        }
        // GET: api/employee

        public List<Employee> Get()
        {
            var result = _employeeStore.GetAll();
            return result;

        }

        // GET: api/employee/5
        [HttpGet()]
        [Route("{id}")]
        public Employee GetbyID(string id)
        {
            var result = _employeeStore.GetByID(id);
            return result;
        }

        [HttpGet()]
        [Route("email/{email}")]
        // GET: api/employee/shahchaitali29@gmail.com
        public Employee SearchByEmail(string email)
        {
            var result = _employeeStore.GetByEmail(email);
            return result;
        }

        // POST: api/employee
        public void Post([FromBody]Employee value)
        {
         
        }
       
       
      
        public void Put([FromBody]Employee value)
        {
            _employeeStore.Save(value);
        }

        // DELETE: api/employee/5
        public void Delete(int id)
        {
        }
    }
}
