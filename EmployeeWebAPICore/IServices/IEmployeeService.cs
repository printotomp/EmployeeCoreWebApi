using EmployeeWebAPICore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeWebAPICore.IServices
{
    public interface IEmployeeService
    {
        public Task<IEnumerable<Employee>> GetEmployee();
        Task<List<Employee>> GetEmployeeById(int id);
        public Employee AddEmployee(Employee employee);
        public Employee UpdateEmployee(Employee employee);
        Task<Employee> DeleteEmployee(int id);
    }
}
