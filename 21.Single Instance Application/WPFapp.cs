using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace _21.Single_Instance_Application
{
    class WPFapp : Application
    {
        protected override void OnStartup(StartupEventArgs e)//重写启动app事件
        {
            base.OnStartup(e);

            showWindow();
        }

        public void showWindow()
        {
            MainWindow win = new MainWindow();
            win.Show();
        }
    }
}
