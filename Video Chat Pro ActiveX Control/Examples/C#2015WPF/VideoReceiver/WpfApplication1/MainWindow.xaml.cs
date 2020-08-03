using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
          
        }

        private void buttonDisconnectListen_Click(object sender, RoutedEventArgs e)
        {
            axVideoChatReceiver.Disconnect();
        }

        private void buttonStartListen_Click(object sender, RoutedEventArgs e)
        {
            axVideoChatReceiver.Disconnect();
            axVideoChatReceiver.Listen(txtListenIP.Text, Convert.ToInt32(txtListenPortno.Text, 10));
        }

        private void buttonDisConnect_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void buttonConnect_Click(object sender, RoutedEventArgs e)
        {
         
        }
    }
}
