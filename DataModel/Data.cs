using System.Collections.Generic;
using System.IO;

namespace DataModel
{
    public class Data
    {
        public List<Address> AddressList { get; set; }
        public int AI_Address;

        public List<Order> OrderList { get; set; }
        public int AI_Order;

        public List<User> UserList { get; set; }
        public int AI_User;

        public List<AddressUserLink> AddressUserLinksList { get; set; }
        public int AI_AddressUserLink;

        public Data()
        {
            AddressList = new List<Address>();
            OrderList = new List<Order>();
            UserList = new List<User>();
            AddressUserLinksList = new List<AddressUserLink>();
        }

        public void AddUser(User usr)
        {
            UserList.Add(usr);
            //using (StreamWriter sw = new StreamWriter(@"C:\Users\vambr\Desktop\wcf.txt", false, System.Text.Encoding.Default))
            //{
            //    sw.WriteLine("i'm here");
            //}
        }

        public void AddOrder(Order ord)
        {
            OrderList.Add(ord);
        }

        public void AddAddress(Address addr)
        {
            AddressList.Add(addr);
        }

        public void AddAddressUserLink(AddressUserLink addrord)
        {
            AddressUserLinksList.Add(addrord);
        }

        public void RemoveUser(User usr)
        {
            UserList.Remove(usr);
        }

        public void RemoveOrder(Order ord)
        {
            OrderList.Remove(ord);
        }

        public void RemoveAddress(Address addr)
        {
            AddressList.Remove(addr);
        }

        public void RemoveAddressUserLink(AddressUserLink addrord)
        {
            AddressUserLinksList.Remove(addrord);
        }


    }
}
