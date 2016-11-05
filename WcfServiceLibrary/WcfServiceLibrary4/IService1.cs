using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract(CallbackContract = typeof(IClient_Chat_Callback))]
    public interface IService_Chat
    {
        [OperationContract]
        bool Join(string nickname, string password, bool register);

        [OperationContract(IsOneWay = true)]
        void Send_messageToServer(Message msg);

        [OperationContract(IsOneWay = true)]
        void Leave();
    }

    public interface IClient_Chat_Callback
    {
        [OperationContract(IsOneWay = true)]
        void Update_visitors_list(List<Visitor> visitors);

        [OperationContract(IsOneWay = true)]
        void Send_messageToClient(Message msg);

    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "WcfServiceLibrary4.ContractType".
    [DataContract]
    public class Message
    {
        [DataMember]
        public string message;

        [DataMember]
        public Visitor sender;

        [DataMember]
        public Visitor addressee;

        public Message()
        {

        }

        public Message(string _message, Visitor _sender = null, Visitor addressee = null)
        {
            this.message = _message;
            this.sender = _sender;
            this.addressee = addressee;
        }
    }

    [DataContract]
    public class Visitor
    {
        [DataMember]
        public string nickname;

        public IClient_Chat_Callback callback;

        public Visitor(string _nickname, IClient_Chat_Callback _callback = null)
        {
            nickname = _nickname;
            callback = _callback;
        }
    }
}
