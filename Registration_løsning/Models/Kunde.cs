using System;
using System.ComponentModel.DataAnnotations;

using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Registration_løsning.Models

{
    public class Kunde
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Feltet m? fylles inn*.")]
        [RegularExpression(@"^(([A-Za-z]+[\s]{1}[A-Za-z]+)|([A-za-z]+))$", ErrorMessage = "Inkorrekt Fornavn.")]

        public String Firstname { get; set; }


        [Required(ErrorMessage = "Feltet m? fylles inn* Hva skjer.")]
        [RegularExpression(@"^(([A-Za-z]+[\s]{1}[A-Za-z]+)|([A-za-z]+))$", ErrorMessage = "Inkorrekt Fornavn.")]

        public String Lastname { get; set; }



        [Required(ErrorMessage = "Feltet m? fylles inn*.")]
        [RegularExpression(@"^[A-Za-z0-9][-a-z0-9.!#$%&'*+-=?^_`{|}~\/]+@([-a-z0-9]+\.)+[a-z]{2,5}$", ErrorMessage = "Skriv inn korrekt email.")]
        public String Email { get; set; }





        [Required(ErrorMessage = "Feltet m? fylles inn*.")]
        [RegularExpression(@"^[A-Za-z0-9]{6,15}$", ErrorMessage = "Skriv inn Korrekt Passord.")]
        [DataType(DataType.Password)]
        public String Password { get; set; }
        public List<Order> Order { get; set; }



    }
}