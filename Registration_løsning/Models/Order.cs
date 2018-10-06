
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Registration_løsning.Models;

namespace Registration_løsning.Models
{
    public class Order
    {
        public int Id { get; set; } 
        public Kunde Kunde { get; set; }
        public Film Film { get; set; }
       

    }


}