using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class Order
    {
        public int Id { get; set; }
        public string GoodName { get; set; }
        public int AddressID { get; set; }
        public int UserID { get; set; }
        
        public Order(int id, string name, int user_id, int address_id)
        {
            Id = id;
            GoodName = name;
            AddressID = address_id;
            UserID = user_id;
        }
    }
}
