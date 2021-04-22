using AutoMapper;
using EmployeeWebAPICore.DTO;
using EmployeeWebAPICore.Models;

namespace EmployeeWebAPICore
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<EmployeeDTO, Employee>().ReverseMap();
        }
    }
}