using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stationery_Store.Entities
{
    public class Order
    {
        public int ID { get; set; }
        public DateOnly Date {  get; set; }
        public int Total_Amount { get; set; }
        public double Total_Price { get; set; }

    }
}
