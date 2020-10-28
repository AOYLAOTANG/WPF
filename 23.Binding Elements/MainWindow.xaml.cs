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

namespace _23.Binding_Elements
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
            //this.slider1.Value = 30;
            this.textBlock1.FontSize = 30;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Binding bind = new Binding();//新建一个绑定类

            bind.Source = slider1;//设置绑定源对象
            bind.Path = new PropertyPath("Value"); //设置绑定源属性
            bind.Mode = BindingMode.TwoWay;//设置绑定模式;

            this.textBlock1.SetBinding(TextBlock.FontSizeProperty,bind);//设置绑定目标对象
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            BindingOperations.ClearAllBindings(this.textBlock1);//删除绑定关系
        }
    }
}
