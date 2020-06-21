using System.Collections.Generic;
using EmployeeRegistration.Dtos;
using EmployeeRegistration.Models;

namespace EmployeeRegistration.Data
{
    public interface IEmployeeRepo
    {
        bool SaveChanges();
        void CreateEmployee(Employee employee);
        IEnumerable<Employee> GetAllEmployees();
        Employee GetEmployeeById(int id);
    }
}