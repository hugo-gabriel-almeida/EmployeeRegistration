using EmployeeRegistration.Models;

namespace EmployeeRegistration.Data
{
    public interface IEmployeeRepo
    {
        bool SaveChanges();
        void CreateEmployee(Employee employee);
    }
}