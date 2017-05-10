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
    [Authorize]
   

    public class ValuesController : ApiController
    {
        private IEmployeeStorage _employeeStore;

        public ValuesController()
        {
            _employeeStore = new EmployeeStorage();
        }
        // GET api/values
        public IEnumerable<Employee> Get()
        {
            var result = _employeeStore.GetAll();
            return result;
            //  return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public Employee Get(string id)
        {
            var result = _employeeStore.GetByID(id);
            return result;
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
