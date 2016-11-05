using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientChat.ServiceReference1;

namespace ClientChat.Connection
{
    public class WCFClient : IService_ChatCallback
    {
        public void Update_visitors_list(Visitor[] _visitors)
        {
            if (BL.Visitors.Count != 0)
                BL.Visitors.Clear();
            foreach (Visitor v in _visitors)
                BL.Visitors.Add(v.nickname);
        }

        public void Send_messageToClient(Message msg)
        {
            BL.MessagesList.Add(String.Format("{0:HH:mm:ss} ", DateTime.Now) + " " + msg.sender.nickname + " : " + msg.message);
        }
    }
}
