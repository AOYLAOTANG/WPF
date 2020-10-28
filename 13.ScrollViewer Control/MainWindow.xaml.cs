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

namespace _13.ScrollViewer_Control
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

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.scrollViewer1.LineDown();//向下滚动一行
            //this.scrollViewer1.LineUp();//向上滚动一行
            //this.scrollViewer1.PageDown();//向下滚动一页
            //this.scrollViewer1.PageUp();//向上滚动一页
            //this.scrollViewer1.ScrollToEnd();//向下滚动到底部
            //this.scrollViewer1.ScrollToHome();//向上滚动到顶部
        }
    }
}
