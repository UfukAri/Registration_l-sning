using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Registration_løsning.Models
{
    public class UserAccount
    {

        [Key]
        public int UserID { get; set; }

        [Required(ErrorMessage = "Feltet må fylles inn*.")]
        [RegularExpression(@"^(([A-Za-z]+[\s]{1}[A-Za-z]+)|([A-za-z]+))$", ErrorMessage = "Inkorrekt Fornavn.")]
        public String Firstname { get; set; }


        [Required(ErrorMessage = "Feltet må fylles inn*")]
        public String Lastname { get; set; }


        [Required(ErrorMessage = "Feltet må fylles inn*.")]
        [RegularExpression(@"^[A-Za-z0-9][-a-z0-9.!#$%&'*+-=?^_`{|}~\/]+@([-a-z0-9]+\.)+[a-z]{2,5}$", ErrorMessage = "Skriv inn korrekt email.")]
        public String Email { get; set; }


        [Required(ErrorMessage = "Feltet må fylles inn*.")]
        [RegularExpression(@"^[A-Za-z0-9]{6,15}$", ErrorMessage = "Brukernavn må være tegn mellom 6-15 Bokstaver og tall")]
        public String Username { get; set; }


        [Required(ErrorMessage = "Feltet må fylles inn*.")]
        [RegularExpression(@"^[A-Za-z0-9]{6,15}$", ErrorMessage = "Passordet må være tegn mellom 6-15 Bokstaver og tall")]
        [DataType(DataType.Password)]
        public String Password { get; set; }

        [Compare("Password", ErrorMessage = "Ikke samme passord skrevet.")]
        [DataType(DataType.Password)]
        public String ConfirmPassword { get; set; }
    }
}