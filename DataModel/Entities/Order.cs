using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DataModel
{
    public class Order
    {
        //[Key]
        public int Id { get; set; }
        //[Required]
        public string GoodName { get; set; }
        //[Required]
        public int AddressID { get; set; }
        //[Required]
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
