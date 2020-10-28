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

namespace _08.Routing_event
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        protected int eventcount = 0;

        private void SomethingClicked(object sender, RoutedEventArgs e)
        {
            eventcount++;
            string message = "#" + eventcount.ToString() + ":\r\n" +
                "Sender:" + sender.ToString() + ":\r\n" +
                "Source:" + e.Source + ":\r\n" +
                "Original Source:" + e.OriginalSource;
            ListMessages.Items.Add(message);
            e.Handled = (bool)CheckHandle.IsChecked;
        }

        private void cmdClear_Click(object sender, RoutedEventArgs e)
        {
            eventcount = 0;
            ListMessages.Items.Clear();
        }
    }
}
