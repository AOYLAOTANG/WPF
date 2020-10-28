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

namespace _07.Canvas_Layout
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //读取所有的绘图模式类型到下拉选择框中显示
            foreach (InkCanvasEditingMode mode in Enum.GetValues(typeof(InkCanvasEditingMode)))
            {
                this.EditingMode.Items.Add(mode);
            }
            this.EditingMode.SelectedIndex = 0;
        }

        private void EditingMode_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.InkCanvas.EditingMode = (InkCanvasEditingMode)this.EditingMode.SelectedItem;
        }

        //private void button2_Click(object sender, RoutedEventArgs e)
        //{
        //    Canvas.SetZIndex(button1, 1);
        //}
    }
}
