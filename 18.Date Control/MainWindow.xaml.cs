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

namespace _18.Date_Control
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        string dis;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void calendar1_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            //this.Title = calendar1.SelectedDate.ToString();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            dis = "";
            for (int i=0; i < calendar1.SelectedDates.Count; i++)
                dis += calendar1.SelectedDates[i].ToShortDateString()+" ";
            this.Title = dis;
        }

        private void datePicker1_DateValidationError(object sender, DatePickerDateValidationErrorEventArgs e)
        {
            MessageBox.Show(e.Text + " 该日期非法 " + e.Exception.Message );
        }
    }
}
