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
using System.Windows.Shapes;

namespace _20.Applicatin_Class_II
{
    /// <summary>
    /// Window1.xaml 的交互逻辑
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("当前主窗口为：" + Application.Current.MainWindow.Title);
            //string mes = "";
            //foreach (Window window in Application.Current.Windows)
            //    mes += "已打开窗口：" + window.Title.ToString() + "\r\n";
            //MessageBox.Show(mes);

            Document doc = new Document();
            doc.Owner = this;
            doc.Show();

            ((App)Application.Current).Documents.Add(doc);//将新的文档窗口添加到集合中
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            foreach (Document doc in ((App)Application.Current).Documents)
            {
                doc.Content = "文档更新时间：" + DateTime.Now.ToLongTimeString();
            }
        }
    }
}
