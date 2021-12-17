using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace CV_Site_Grp19.Models
{
    public class User
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage ="Vänligen skriv ett namn!")]
        public string Name { get; set; }

        [Required (ErrorMessage ="Vänligen fyll i en adress")]
        public string Adress { get; set; }

        [Required(ErrorMessage = "Vänligen fyll i en Email")]
        public string Email { get;  set; }

        [Required(ErrorMessage = "Vänligen fyll i ett användarnamn")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Vänligen skriv ett lösenord!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage ="Please confirm password")]
        [Required(ErrorMessage = "Vänligen bekräfta ditt lösenord!")]
        public string ConfirmPassword { get ;  set; }

        public User(string name, string adress, string email)
        {
            Name = name;
            Adress = adress;
            Email = email;
        }


    }
}