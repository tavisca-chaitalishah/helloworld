using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using tavisca.EmployeeManagementWebApi.BusinessLayer.Interface;
using tavisca.EmployeeManagementWebApi.BusinessLayer.Model;

namespace tavisca.EmployeeManagementWebApi.DataAccess
{
    public class EmployeeStorage : IEmployeeStorage
    {
        protected static IMongoClient _client;
        protected static IMongoDatabase _database;
        private IMongoCollection<Employee> _collection;

        public EmployeeStorage()
        {
            _client = new MongoClient();
            _database = _client.GetDatabase("Employee");
            _collection = _database.GetCollection<Employee>("EmployeeDatabase");
        }
        public Employee GetByID(string employeeId)
        {
            var filter = Builders<Employee>.Filter.Eq("Id", employeeId);
            Employee result = (Employee)_collection.Find(filter);
            return result;



        }

        public List<Employee> GetAll()
        {
            return _collection.Find(x => x.Id != null).ToList<Employee>();
        }
       
        public Employee GetByEmail(string email)
        {
            var filter = Builders<Employee>.Filter.Eq("Email", email);
            Employee result = (Employee)_collection.Find(filter);
            return result;
        }

        public Employee Save(Employee employee)
        {
            _collection.InsertOne(employee);
            return employee;
        }

        public PagedList<Employee> GetEmployees(int pageNumber = 1, int pageSize = 20, string orderBy = "Id", SortingOrder sortingOrder = SortingOrder.DESC)
        {
            throw new NotImplementedException();
        }
    }
}