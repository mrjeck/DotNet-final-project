using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DAL;
using System.Threading;

namespace WcfServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class Chat : IService_Chat
    {
        private static List<Visitor> visitors = new List<Visitor>();

        public bool Join(string nickname, string password, bool register)
        {
            bool resault = false;
            resault = Check_in_Base(nickname, password);
            if (register && !resault)
            { 
                  Visitor_Register(nickname, password);
                  resault = true;
            }
            if (resault)
            { 
                  visitors.Add(new Visitor(nickname, OperationContext.Current.GetCallbackChannel<IClient_Chat_Callback>()));
                  Thread t = new Thread(this.Send);
                  t.Start(nickname);
            }
            return resault;
        }

        private void Send(object nickname)
        {
            foreach (Visitor v in visitors)
            {
                v.callback.Update_visitors_list(visitors);
                v.callback.Send_messageToClient(new Message("join chat", new Visitor((string)nickname)));
            }
        }

        private bool Check_in_Base(string nickname, string password)
        {
            return DBConnector.CheckVisitor(nickname, password);
        }

        public void Visitor_Register(string nickname, string password)
        {
            DBConnector.Add_visitor(nickname, password);    
        }

        public void Send_messageToServer(Message msg)
        {
            Visitor sender_visitor = visitors.First(x => x.callback == OperationContext.Current.Channel);
                foreach (Visitor v in visitors)
                {
                    v.callback.Send_messageToClient(new Message(msg.message, sender_visitor));
                }
        }

        public void Leave()
        {
            Visitor removing_visitor = visitors.First(x => x.callback == OperationContext.Current.Channel);
            visitors.Remove(removing_visitor);
            foreach (Visitor v in visitors)
            {
                v.callback.Update_visitors_list(visitors);
                v.callback.Send_messageToClient(new Message("left chat", new Visitor(removing_visitor.nickname)));
            }
        }
    }
}
