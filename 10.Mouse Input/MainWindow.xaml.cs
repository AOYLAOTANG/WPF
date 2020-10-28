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

namespace _10.Mouse_Input
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

        private void label1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //初始化拖放的源元素
            Label lbl = (Label)sender;
            DragDrop.DoDragDrop(lbl, lbl.Content, DragDropEffects.Copy);
        }

        private void label2_Drop(object sender, DragEventArgs e)
        {
            //设置拖放的接收元素
            ((Label)sender).Content = e.Data.GetData(DataFormats.Text);
        }

        //private void rect_MouseMove(object sender, MouseEventArgs e)
        //{
        //    Point pt = e.GetPosition(this);
        //    posInfo.Text = "鼠标位置：" + pt.ToString();
        //}

        //private void cmdCapture_Click(object sender, RoutedEventArgs e)
        //{
        //    Mouse.Capture(this.rect);
        //    this.cmdCapture.Content = "鼠标已捕获";
        //}
    }
}
