using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DataModel
{
    public class User
    {
        //[Key]
        public int Id { get; set; }
        //[Required]
        public string Name { get; set; }
        public List<int> OrderList { get; set; }
        public List<int> AddressList { get; set; }

        public User(int id, string name)
        {
            Id = id;
            Name = name;
            OrderList = new List<int>();
            AddressList = new List<int>();
        }
    }
}
