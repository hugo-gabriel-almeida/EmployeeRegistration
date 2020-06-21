using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeRegistration.Dtos
{
    public class EmployeeReadDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public string BirthDay { get; set; }
        
        public string Email { get; set; }
        
        public char Genre { get; set; }
        
        public string Skills { get; set; }
    }
}