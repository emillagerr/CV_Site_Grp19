using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CVSite_Grupp19.Models
{
    public class UserAccount 
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage ="Vänligen fyll i ett namn ")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Vänligen fyll i ett namn ")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Vänligen fyll i ett namn ")]

        public string Username { get; set; }

        [Required(ErrorMessage = "Vänligen fyll i ett namn ")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Vänligen fyll i ett namn ")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }


    }
}