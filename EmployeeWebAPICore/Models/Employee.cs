using System;
using System.Collections.Generic;

#nullable disable

namespace EmployeeWebAPICore.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public decimal? Salary { get; set; }
    }
}
