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

namespace _15.TextBox_and_PasswordBox
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

        private void textBox1_SelectionChanged(object sender, RoutedEventArgs e)
        {
            if (this.txtSelection == null) return;
            this.txtSelection.Text = "选中文本从第" + (this.textBox1.SelectionStart+1) + "个字到第" 
                + this.textBox1.SelectionLength + "个字，选中内容为：" + this.textBox1.SelectedText;
        }
    }
}
