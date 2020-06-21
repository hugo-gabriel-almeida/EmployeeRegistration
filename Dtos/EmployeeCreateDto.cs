using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic.CompilerServices;

namespace EmployeeRegistration.Dtos
{
    public class EmployeeCreateDto
    {
        [Required(ErrorMessage = "Nome obrigatório com tamnhano maximo de 15 caracteres")]
        [MaxLength(15)]
        public string FirstName { get; set; }
        
        [Required(ErrorMessage = "Sobrenome obrigatório com tamnhano maximo de 100 caracteres")]
        [MaxLength(100)]
        public string LastName { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "dd/MM/yyyy")]    
        public string BirthDay { get; set; }
        
        [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",
        ErrorMessage="Email inválido")]
        public string Email { get; set; }

        [Required]
        
        public char Genre { get; set; }
        
        [Required(ErrorMessage ="Habidates Permitidas: C#, Java, Angular, SQL, ASP")]
        [RegularExpression("/^C#$|^Java$|^Angular$|^SQL$|^ASP$|/")]
        public string Skills { get; set; }
    }
}