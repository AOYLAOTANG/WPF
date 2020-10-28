using System.Windows;
using System.Windows.Controls;
using System.IO;
using System.Windows.Markup;

namespace _03.create_wpf_by_xaml
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private Button myButton;

        public MainWindow()
        {
            InitializeComponent();
        }

        //重载构造函数，以xaml文件的名称为参数
        public MainWindow(string xamlFile)
        {
            //设置窗体的属性
            this.Width = this.Height = 285;
            this.Left = this.Top = 100;
            this.Title = "Danamically Loaded XAML";

            //从外部文件获取xaml的内容
            DependencyObject rootElement;//定义一个依赖来接收xaml文件读取的内容
            using (FileStream fs = new FileStream(xamlFile, FileMode.Open))
            {
                rootElement = (DependencyObject)XamlReader.Load(fs);
            }
            this.Content = rootElement;//将依赖的内容赋值给窗体的content属性
            
            //从xaml的内容中找到button1名字的按钮，并赋值给mybutton对象
            myButton = (Button)LogicalTreeHelper.FindLogicalNode(rootElement, "button1");

            //添加事件处理程序
            myButton.Click += myButton_Click;
        }

        private void myButton_Click(object sender, RoutedEventArgs e)
        {
            myButton.Content = "成功";
        }
    }
}
