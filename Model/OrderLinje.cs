using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class OrderLinje
    {
        public int Id { get; set; }
        public Film Film { get; set; }
        public Order Order { get; set; }

        public OrderLinje(Film film, Order order)
        {
            Film = film;
            Order = Order;

        }
        public OrderLinje() { }
    }
}
