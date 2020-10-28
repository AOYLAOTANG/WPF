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

namespace _16.List_and_Combo_Control
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

        private void listBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listBox1.SelectedItem == null) return;
            this.textSelection.Text = "选择的选项为：" + (listBox1.SelectedIndex+1) + "\r\n"
                + "选中状态为:" + ((CheckBox)listBox1.SelectedItem).IsChecked;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (CheckBox item in listBox1.Items)
            {
                if (item.IsChecked == true)
                {
                    sb.Append(item.Content);
                    sb.Append("被选中\r\n");
                }
                textSelection.Text = sb.ToString();
            }
        }
    }
}
