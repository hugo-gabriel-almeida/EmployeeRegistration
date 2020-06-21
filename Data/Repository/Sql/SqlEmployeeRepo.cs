using System;
using System.Collections.Generic;
using System.Linq;
using EmployeeRegistration.Models;

namespace EmployeeRegistration.Data
{
    public class SqlEmployeeRepo : IEmployeeRepo
    {
        private readonly EmployeeRegistrationContext _context;

        public SqlEmployeeRepo(EmployeeRegistrationContext context)
        {
            _context = context;
        }

        public void CreateEmployee(Employee employee)
        {
            if (employee == null)
            {
                throw new ArgumentNullException(nameof(employee));
            }

            _context.Add(employee);
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _context.Employee.ToList();
        }

        public Employee GetEmployeeById(int id)
        {
            return _context.Employee.FirstOrDefault(p => p.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}