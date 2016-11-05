using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ClientChat.ServiceReference1;

namespace ClientChat
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void VisitorLogin(bool register)
        {
            if (BL.proxy.Join(username.Text, password.Text, register))
                BL.login_resault = true;
            this.Close(); 
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            VisitorLogin(false);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            VisitorLogin(true);
        }
    }
}
