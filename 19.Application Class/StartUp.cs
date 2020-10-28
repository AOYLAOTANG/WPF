using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace _19.Application_Class
{
    class StartUp
    {
        [STAThread()]
        static void Main()
        {
            Application app = new Application();
            MainWindow win = new MainWindow();
            win.Title = "My App";
            app.Run(win);
        }
    }
}
