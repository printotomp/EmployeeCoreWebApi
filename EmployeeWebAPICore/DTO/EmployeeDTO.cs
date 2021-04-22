using System;
using System.Collections.Generic;

#nullable disable

namespace EmployeeWebAPICore.DTO
{
    public partial class EmployeeDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public decimal? Salary { get; set; }
    }
}
