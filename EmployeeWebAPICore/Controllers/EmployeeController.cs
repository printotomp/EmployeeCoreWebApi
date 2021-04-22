using System.Collections.Generic;
using EmployeeWebAPICore.IServices;
using EmployeeWebAPICore.Models;
using Microsoft.AspNetCore.Mvc;
using EmployeeWebAPICore.IServices;
using EmployeeWebAPICore.Models;
using AutoMapper;
using EmployeeWebAPICore.DTO;
using System.Threading.Tasks;
using AutoMapper.QueryableExtensions;

namespace EmployeeWebAPICore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IMapper _mapper;

        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employee, IMapper mapper)
        {
            _employeeService = employee;
            _mapper = mapper;
        }
        [HttpGet]
        [Route("[action]")]
        //[Route("api/GetEmployee")]
        public async Task<IEnumerable<Employee>> GetEmployee()
        {
            return await _employeeService.GetEmployee();
        }

        [HttpPost]
        [Route("[action]")]
        //[Route("api/Employee/AddEmployee")]
        public IActionResult AddEmployee(Employee employee)
        {
            var emp = _employeeService.AddEmployee(employee);
            var employeee = _mapper.Map<EmployeeDTO>(emp);
            return Ok(employeee);
        }
        [HttpPut]
        [Route("[action]")]
        //[Route("api/Employee/EditEmployee")]
        public IActionResult EditEmployee(Employee employee)
        {
            var emp = _employeeService.UpdateEmployee(employee);
            var employeee = _mapper.Map<List<EmployeeDTO>>(emp);
            return Ok(employeee);
        }

        [HttpDelete]
        [Route("[action]")]
        //[Route("api/Employee/DeleteEmployee")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            var emp = _employeeService.DeleteEmployee(id);
            //var employee = _mapper.Map<List<EmployeeDTO>>(emp);
            return Ok(await emp);
        }

        [HttpGet]
        [Route("[action]")]
        //[Route("api/Employee/GetEmployeeId")]
        public async Task<IActionResult> GetEmployeeId(int id)
        {
            var emp = await _employeeService.GetEmployeeById(id);
            var employee = _mapper.Map<List<EmployeeDTO>>(emp);
            return Ok(employee);
        }
    }
}
