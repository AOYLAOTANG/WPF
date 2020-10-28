using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using System.IO;

namespace _20.Applicatin_Class_II
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        //private void Application_Startup(object sender, StartupEventArgs e)
        //{
        //    MainWindow win = new MainWindow();
        //    if (e.Args.Length > 0)//判断是否有命令行参数
        //    {
        //        string file = e.Args[0];
        //        if (File.Exists(file))//判断文本文件是否存在
        //            win.LoadFile(file);
        //    }
        //    else
        //        MessageBox.Show("没有设置命令行参数");
        //    win.LoadFile(e.Args[0]);
        //    win.Show();//显示主窗口
        //}

        private List<Document> documents=new List<Document>();

        public List<Document> Documents
        {
            get{ return documents;}
            set{ documents=value;}
        }
    }
}
