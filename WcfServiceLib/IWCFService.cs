using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLib
{
    [ServiceContract]
    public interface IWCFService
    {
        //[OperationContract]
        //void Save();

        //[OperationContract]
        //void Load();

        [OperationContract]
        string GetData();


        [OperationContract]
        int AddUser(string name);

        [OperationContract]
        int AddAddress(string city, string street, int build, int flat);

        [OperationContract]
        int AddOrder(string goodname);


        [OperationContract]
        bool RemoveUser(int UserId);

        [OperationContract]
        bool RemoveAddress(int AddrId);

        [OperationContract]
        bool RemoveOrder(int OrdId);


        [OperationContract]
        bool AddOrderToUser(int OrdId, int UserId);

        [OperationContract]
        bool AddAddressToUser(int AddrId, int UserId);

        [OperationContract]
        bool AddUserToAddress(int UserId, int AddrId);

        [OperationContract]
        bool AddOrderToAddress(int OrderId, int AddrId);


        [OperationContract]
        bool RemoveOrderFromUser(int OrdId, int UserId);

        [OperationContract]
        bool RemoveAddressFromUser(int AddrId, int UserId);

        [OperationContract]
        bool RemoveUserFromAddress(int UserId, int AddrId);

        [OperationContract]
        bool RemoveOrderFromAddress(int OrderId, int AddrId);
    }
}
