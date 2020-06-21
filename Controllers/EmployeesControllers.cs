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
        private readonly IEmployeeRepo _repository;
        private readonly IMapper _mapper;

        public EmployeeController(IEmployeeRepo repository, IMapper mapper)
        {   
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult <IEnumerable<EmployeeReadDto>> GetAllEmployees()
        {
            var employees = _repository.GetAllEmployees();
            return Ok(_mapper.Map<IEnumerable<EmployeeReadDto>>(employees));
        }

        [HttpGet("{id}")]
        public ActionResult <EmployeeReadDto> GetEmployeeById(int id)
        {
            var employee = _repository.GetEmployeeById(id);

            if (employee != null)
            {
                return Ok(_mapper.Map<EmployeeReadDto>(employee));
            }
            return NotFound();
        }

        [HttpPost]
        public ActionResult <EmployeeReadDto> CreateEmployee(EmployeeCreateDto employeeCreateDto)
        {
            var employeModel = _mapper.Map<Employee>(employeeCreateDto);
            _repository.CreateEmployee(employeModel);
            _repository.SaveChanges();

            var employeeReadDto = _mapper.Map<EmployeeReadDto>(employeModel);

            return employeeReadDto;
        }

        [HttpPut("{id}")]
        public ActionResult <EmployeeReadDto> UpdateEmployee(int id,EmployeeUpdateDto employeeUpdateDto)
        {
            var employeeModel = _repository.GetEmployeeById(id);
            if (employeeModel == null)
            {
                return NotFound("Funcionário não encontrado");
            }
            
            _mapper.Map(employeeUpdateDto, employeeModel);
            _repository.UpdateEmployee(employeeModel);
            _repository.SaveChanges();

            return NoContent();
        }
    }
    
}