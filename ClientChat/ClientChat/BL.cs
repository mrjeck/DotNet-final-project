using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ClientChat.Connection;
using ClientChat.ServiceReference1;

namespace ClientChat
{
    public static class BL
    {
        public static bool login_resault = false;

        private static InstanceContext site;

        public static Service_ChatClient proxy;

        public static string visitor_name;

        static ObservableCollection<string> _Visitors;
        public static ObservableCollection<string> Visitors
        {
            get
            {
                return _Visitors;
            }
            set
            {
                _Visitors = value;
            }
        }

        static ObservableCollection<string> _MessagesList;
        public static ObservableCollection<string> MessagesList
        {
            get
            {
                return _MessagesList;
            }
            set
            {
                _MessagesList = value;
            }
        }

        static BL()
        {
            _Visitors = new ObservableCollection<string>();
            _MessagesList = new ObservableCollection<string>();
            site = new InstanceContext(new WCFClient());
            proxy = new ClientChat.ServiceReference1.Service_ChatClient(site);
        }
    }
}
