﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Kunde
    {


        public int id { get; set; }

        [Required(ErrorMessage = "Feltet m? fylles inn*.")]
        [RegularExpression(@"^(([A-Za-z]+[\s]{1}[A-Za-z]+)|([A-za-z]+))$", ErrorMessage = "Inkorrekt Fornavn.")]

        public String Firstname { get; set; }


        [Required(ErrorMessage = "Feltet m? fylles inn* Hva skjer.")]
        [RegularExpression(@"^(([A-Za-z]+[\s]{1}[A-Za-z]+)|([A-za-z]+))$", ErrorMessage = "Inkorrekt Fornavn.")]

        public String Lastname { get; set; }



        [Required(ErrorMessage = "Feltet m? fylles inn*.")]
        [RegularExpression(@"^[A-Za-z0-9][A-Za-z0-9.!#$%&'*+-=?^_`{|}~\/]+@([A-Za-z0-9]+\.)+[a-z]{2,5}$", ErrorMessage = "Skriv inn korrekt email.")]
        public String Email { get; set; }





        [Required(ErrorMessage = "Feltet m? fylles inn*.")]
        [RegularExpression(@"^[A-Za-z0-9]{6,15}$", ErrorMessage = "Skriv inn Korrekt Passord.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public List<Order> Order { get; set; }
        [ForeignKey("Poststed")]
        public int PoststedId { get; set; }
        public virtual Poststed Poststed { get; set; }


    }


    public class dbKunde
    {

        public int id { get; set; }
        public byte[] Password { get; set; }

        [Required(ErrorMessage = "Feltet m? fylles inn*.")]
        [RegularExpression(@"^(([A-Za-z]+[\s]{1}[A-Za-z]+)|([A-za-z]+))$", ErrorMessage = "Inkorrekt Fornavn.")]

        public String Firstname { get; set; }


        [Required(ErrorMessage = "Feltet m? fylles inn* Hva skjer.")]
        [RegularExpression(@"^(([A-Za-z]+[\s]{1}[A-Za-z]+)|([A-za-z]+))$", ErrorMessage = "Inkorrekt Fornavn.")]

        public String Lastname { get; set; }



        [Required(ErrorMessage = "Feltet m? fylles inn*.")]
        [RegularExpression(@"^[A-Za-z0-9][A-Za-z0-9.!#$%&'*+-=?^_`{|}~\/]+@([A-Za-z0-9]+\.)+[a-z]{2,5}$", ErrorMessage = "Skriv inn korrekt email.")]
        public String Email { get; set; }

        public List<Order> Ordrer { get; set; }
        [ForeignKey("Poststed")]
        public int PoststedId { get; set; }
        public virtual Poststed Poststed { get; set; }

       
    }


}