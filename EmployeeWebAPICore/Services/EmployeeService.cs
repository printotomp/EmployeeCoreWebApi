using EmployeeWebAPICore.IServices;
using EmployeeWebAPICore.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeWebAPICore.Services
{
    public class EmployeeService : IEmployeeService
    {
        APICoreDBContext dbContext;
        public EmployeeService(APICoreDBContext _db)
        {
            dbContext = _db;
        }

        public async Task<IEnumerable<Employee>> GetEmployee()
        {
            var employee = dbContext.Employees.ToList();
            return employee;
        }

        public Employee AddEmployee(Employee employee)
        {
            if (employee != null)
            {
                dbContext.Employees.Add(employee);
                dbContext.SaveChanges();
                return employee;
            }
            return null;
        }

        public Employee UpdateEmployee(Employee employee)
        {
            dbContext.Entry(employee).State = EntityState.Modified;
            dbContext.SaveChanges();
            return employee;
        }

        public async Task<Employee> DeleteEmployee(int id)
        {
            var employee = await dbContext.Employees.FirstOrDefaultAsync(x => x.Id == id);
            //var employee = await dbContext.Employees.Where(x => x.Id == id).ToListAsync();
            dbContext.Entry(employee).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return employee;
        }

        public async Task<List<Employee>> GetEmployeeById(int id)
        {
            return await dbContext.Employees.Where(x => x.Id == id).ToListAsync();
        }
    }
}