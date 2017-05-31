using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DataModel;
using System.IO;
using Newtonsoft.Json;

namespace WcfServiceLib
{
    public class WCFService : IWCFService
    {
        private DataModel.DataModelContext db;
        private DataModel.Data data;
        private string path;

        public WCFService()
        {
            data = new Data();
            //Load();
            db = new DataModelContext();
            path = @"C:\Users\vambr\Desktop\data.txt";
            //var user = new User(30, "vlad");
            //db.Users.Add(user);
            //db.SaveChanges();
        }

        public int AddUser(string name)
        {
            var user = new User(data.AI_User++, name);
            data.AddUser(user);
            db.Users.Add(user);
            db.SaveChanges();
            Save();
            return user.Id;
            //return 0;
        }

        public int AddAddress(string city, string street, int build, int flat)
        {
            var addr = new Address(data.AI_Address++, city, street, build, flat);
            data.AddAddress(addr);
            db.Addresses.Add(addr);
            db.SaveChanges();
            return addr.Id;
        }

        public int AddOrder(string goodname, int UserId, int AddrId)
        {
            var ord = new Order(data.AI_Order++, goodname, UserId, AddrId);
            data.AddOrder(ord);
            db.Orders.Add(ord);
            db.SaveChanges();
            return ord.Id;
        }

        public int AddAddressUserLink(int UserId, int AddrId)
        {
            var link = new AddressUserLink(data.AI_AddressUserLink, UserId, AddrId);
            data.AddAddressUserLink(link);
            db.AddressUserLinks.Add(link);
            db.SaveChanges();
            return link.Id;
        }


        public bool RemoveUser(int UserId)
        {
            if (data.UserList.Exists(x => x.Id == UserId))
            {
                data.RemoveUser(data.UserList.Find(x => x.Id == UserId));
                User user = db.Users.Find(UserId);
                db.Users.Remove(user);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RemoveOrder(int OrdId)
        {
            if (data.OrderList.Exists(x => x.Id == OrdId))
            {
                data.RemoveOrder(data.OrderList.Find(x => x.Id == OrdId));
                Order ord = db.Orders.Find(OrdId);
                db.Orders.Remove(ord);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RemoveAddress(int AddrId)
        {
            if (data.AddressList.Exists(x => x.Id == AddrId))
            {
                data.RemoveAddress(data.AddressList.Find(x => x.Id == AddrId));
                Address addr = db.Addresses.Find(AddrId);
                db.Addresses.Remove(addr);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RemoveAddressUserLink(int LinkId)
        {
            if (data.AddressUserLinksList.Exists(x => x.Id == LinkId))
            {
                data.RemoveAddressUserLink(data.AddressUserLinksList.Find(x => x.Id == LinkId));
                AddressUserLink link = db.AddressUserLinks.Find(LinkId);
                db.AddressUserLinks.Remove(link);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Load()
        {
            string json = File.ReadAllText(path);
            data = JsonConvert.DeserializeObject<Data>(json, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            });
        }

        private void Save()
        {
            string json = JsonConvert.SerializeObject(data, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All,
                Formatting = Formatting.Indented
            });
            File.WriteAllText(path, json);
        }
    }
}
