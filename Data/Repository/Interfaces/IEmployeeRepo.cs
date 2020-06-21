using System.Collections.Generic;
using EmployeeRegistration.Dtos;
using EmployeeRegistration.Models;

namespace EmployeeRegistration.Data
{
    public interface IEmployeeRepo
    {
        bool SaveChanges();
        IEnumerable<Employee> GetAllEmployees();
        Employee GetEmployeeById(int id);
        void CreateEmployee(Employee employee);
        void UpdateEmployee(Employee employee);
    }
}