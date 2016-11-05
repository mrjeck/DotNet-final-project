using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;
using System.Windows;
using ClientChat.Connection;
using ClientChat.ServiceReference1;

namespace ClientChat
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static bool login_resault;

        private static InstanceContext site;

        public static Service_ChatClient proxy;

        public static List<Visitor> visitors;

        App()
        {
            visitors = new List<Visitor>();
            site = new InstanceContext(new WCFClient());
            proxy = new ClientChat.ServiceReference1.Service_ChatClient(site);
        }
    }
}
