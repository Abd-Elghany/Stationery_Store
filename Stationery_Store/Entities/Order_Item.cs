using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stationery_Store.Entities
{
    public class Order_Item
    {
        public int ID { get; set; }
        public int Quantity { get; set; }
        public double Unit_Price { get; set; }
        
        [ForeignKey("Order_ID")]
        public int Order_ID { get; set; }
        public Order Order { get; set; }
        
        [ForeignKey("Product_ID")]
        public int Product_ID { get; set; }
        public Product Product { get; set; }
    }
}
