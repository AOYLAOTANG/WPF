using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace _02.create_wpf_by_code
{
    class Window1 : Window
    {
        private Button button1;

        public Window1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            //设置窗体大小
            this.Width = 285; this.Height = 250;
            this.Left = 100; this.Top = 100;
            this.Title = "Create Window By Code";

            //创建一个停靠面板对象，用来放组件
            DockPanel panel = new DockPanel();

            //创建按钮对象
            button1 = new Button();
            button1.Content = "点击";
            button1.Margin = new Thickness(30);

            //添加事件处理程序
            button1.Click += btn1_Click;

            //将按钮添加到面板中
            IAddChild container = panel;
            container.AddChild(button1);

            //将面板添加到Window窗体中
            container = this;
            container.AddChild(panel);

        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            button1.Content = "成功";
        }
    }
}
