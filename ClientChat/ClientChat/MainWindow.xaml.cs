using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ClientChat.Connection;
using ClientChat.ServiceReference1;

namespace ClientChat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Login login_window = new Login();
            login_window.ShowDialog();
            if (BL.login_resault != true)
            {
                MessageBoxResult result = MessageBox.Show("Incorrect login or password", "Connection Error", MessageBoxButton.OK, MessageBoxImage.Error);
                this.Close();
            }
        }

        private void Send_message()
        { 
            Message New_message = new Message();
            New_message.message = Message_Content.Text;
            Message_Content.Text = string.Empty;
            BL.proxy.Send_messageToServerAsync(New_message);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(BL.login_resault)
                BL.proxy.Leave();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Send_message();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            Send_message();
        }
    }
}
