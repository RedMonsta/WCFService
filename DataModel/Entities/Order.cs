﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DataModel
{
    public class Order
    {
        public int Id { get; set; }
        public string GoodName { get; set; }
        public int AddressID { get; set; }
        public int UserID { get; set; }
        
        public Order(int id, string name)
        {
            Id = id;
            GoodName = name;
            AddressID = -1;
            UserID = -1;
        }
    }
}
