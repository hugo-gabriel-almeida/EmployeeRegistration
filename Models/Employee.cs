using System.ComponentModel.DataAnnotations;

namespace EmployeeRegistration.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        public DataType BirthDay { get; set; }
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail em formato inválido.")]
        public string Email { get; set; }
        [Required]
        public char Genre { get; set; }
        [Required]
        [RegularExpression("/(^C#$|^Java$|^Angular$|^SQL$|^ASP$|)/")]
        public string Skills { get; set; }
    }
}