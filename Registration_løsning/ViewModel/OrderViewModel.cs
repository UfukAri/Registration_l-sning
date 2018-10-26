using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Registration_løsning.ViewModel
{
    public class OrderViewModel
    {
        public int OrderId { get; set; }
        public dbKunde Kunde { get; set; }
        // Bør ha dato her
        public List<OrderLinje> OrderLinjer { get; set; }

    }
}