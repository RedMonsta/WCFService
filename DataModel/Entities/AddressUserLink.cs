using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DataModel
{
    public class AddressUserLink
    {
        //[Key]
        public int Id { get; set; }
        //[Required]
        public int UserID { get; set; }
        //[Required]
        public int AddressID { get; set; }

        public AddressUserLink(int id, int user_id, int address_id)
        {
            Id = id;
            AddressID = address_id;
            UserID = user_id;
        }
    }


}
