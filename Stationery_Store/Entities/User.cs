using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stationery_Store.Entities
{
    public class User
    {
        public int ID { get; set; }
        public string User_Name { get; set; }
        public string Password { get; set; }
        public string National_ID { get; set; }
        public string Phone { get; set; }
    }
}
