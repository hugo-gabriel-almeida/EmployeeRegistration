using AutoMapper;
using EmployeeRegistration.Data;
using EmployeeRegistration.Dtos;
using EmployeeRegistration.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeControllers
{
    [Route("api/employees")]
    [ApiController]
    public class EmployeeController: ControllerBase
    {
        private readonly IEmployeeRepo _reposutory;
        private readonly IMapper _mapper;

        public EmployeeController(IEmployeeRepo repository, IMapper mapper)
        {   
            _reposutory = repository;
            _mapper = mapper;
        }

        [HttpPost]
        public ActionResult <EmployeeReadDto> CreateEmployee(EmployeeCreateDto employeeCreateDto)
        {
            var employeModel = _mapper.Map<Employee>(employeeCreateDto);
            _reposutory.CreateEmployee(employeModel);
            _reposutory.SaveChanges();

            var employeeReadDto = _mapper.Map<EmployeeReadDto>(employeModel);

            return employeeReadDto;
        }
    }
    
}