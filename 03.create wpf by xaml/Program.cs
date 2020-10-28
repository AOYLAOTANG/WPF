using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace _03.create_wpf_by_xaml
{
    class Program : Application
    {
        [STAThread()]
        static void Main()
        {
            Program app = new Program();
            app.MainWindow = new MainWindow("Window1.xaml");
            app.MainWindow.ShowDialog();
        }
    }
}
