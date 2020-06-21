using System.Collections.Generic;
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

        [HttpGet]
        public ActionResult <IEnumerable<EmployeeReadDto>> GetAllEmployees()
        {
            var employees = _reposutory.GetAllEmployees();
            return Ok(_mapper.Map<IEnumerable<EmployeeReadDto>>(employees));
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