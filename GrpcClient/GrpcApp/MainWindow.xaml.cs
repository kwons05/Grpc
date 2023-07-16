using GrpcModule;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GrpcApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private GrpcHandle GrpcHandle;

        public MainWindow()
        {
            InitializeComponent();

            GrpcHandle = new GrpcHandle();
        }

        private void ReqestButton_Click(object sender, RoutedEventArgs e)
        {
            string requestText = this.ReqestTextBox.Text;

            var reply = GrpcHandle.Client.SayHello(new HelloRequest { Name = requestText });

            this.ReplayTextBox.Text = reply.Message;
        }
    }
}
