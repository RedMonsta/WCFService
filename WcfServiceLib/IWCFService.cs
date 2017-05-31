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

        //[OperationContract]
        //string GetData();


        [OperationContract]
        int AddUser(string name);

        [OperationContract]
        int AddAddress(string city, string street, int build, int flat);

        [OperationContract]
        int AddOrder(string goodname, int UserId, int AddrId);


        [OperationContract]
        bool RemoveUser(int UserId);

        [OperationContract]
        bool RemoveAddress(int AddrId);

        [OperationContract]
        bool RemoveOrder(int OrdId);


        //[OperationContract]
        //int AddOrderToUser(int UserId, int OrdId);

        [OperationContract]
        int AddAddressUserLink(int UserId, int AddrId);


        //[OperationContract]
        //bool RemoveOrderFromUser(int UserId, int OrdId);

        //[OperationContract]
        //bool RemoveAddressUserLink(int UserId, int AddrId);

        [OperationContract]
        bool RemoveAddressUserLink(int LinkId);
    }




    // Используйте контракт данных, как показано на следующем примере, чтобы добавить сложные типы к сервисным операциям.
    // В проект можно добавлять XSD-файлы. После построения проекта вы можете напрямую использовать в нем определенные типы данных с пространством имен "WcfServiceLib.ContractType".
    //[DataContract]
    //public class CompositeType
    //{
    //    bool boolValue = true;
    //    string stringValue = "Hello ";

    //    [DataMember]
    //    public bool BoolValue
    //    {
    //        get { return boolValue; }
    //        set { boolValue = value; }
    //    }

    //    [DataMember]
    //    public string StringValue
    //    {
    //        get { return stringValue; }
    //        set { stringValue = value; }
    //    }
    //}
}
