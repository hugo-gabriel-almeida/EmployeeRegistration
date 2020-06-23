using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EmployeeRegistration.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(15)]
        public string FirstName { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }

        [Required]
        public DateTime BirthDay { get; set; }
        
        public string Email { get; set; }
        
        [Required]
        public char Genre { get; set; }
        
        [Required]
        public string Skills { get; set; }
        
        [Required]
        [DefaultValue(false)]
        public bool Active { get; set; }
    }
}