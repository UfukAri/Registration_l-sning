using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Order
    {
        public int Id { get; set; }
        public virtual int dbKundeId { get; set; }
        public dbKunde Kunde { get; set; }


        public List<OrderLinje> OrdreLinjer { get; set; }


    }
}
