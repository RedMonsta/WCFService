using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DataModel
{
   public class Address
   {
        public int Id { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int Build { get; set; }
        public int Flat { get; set; }
        public List<int> OrderList { get; set; }
        public List<int> UserList { get; set; }

        public Address(int id, string city, string street, int build, int flat)
        {
            Id = id;
            City = city;
            Street = street;
            Build = build;
            Flat = flat;
            OrderList = new List<int>();
            UserList = new List<int>();
        }
    }
}
