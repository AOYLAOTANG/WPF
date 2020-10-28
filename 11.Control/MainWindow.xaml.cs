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

namespace _11.Control
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
            this.Cursor = Cursors.Wait;
            //多种赋值方式
            //this.button1.Background = new SolidColorBrush(Colors.AliceBlue);
            //this.button1.Background = new SolidColorBrush(Color.FromRgb(0, 255, 0));
            //this.button1.Foreground = System.Windows.SystemColors.ControlDarkBrush;
            foreach (FontFamily fontFamily in Fonts.SystemFontFamilies)
                this.listBox1.Items.Add(fontFamily);
        }
    }
}
