

namespace EmployeeRegistration.Data
{
    public class SqlEmployeeRepo : IEmployeeRepo
    {
        private readonly EmployeeRegistrationContext _context;

        public SqlEmployeeRepo(EmployeeRegistrationContext context)
        {
            _context = context;
        }
        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}