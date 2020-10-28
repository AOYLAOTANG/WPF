using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Interactivity;

namespace TestLibrary
{
    public class Behavior1:Behavior<UIElement>
    {
        private Canvas canvas;

        //访问放置行为的元素
        protected override void OnAttached()
        {
            base.OnAttached();

            //关联事件处理程序
            this.AssociatedObject.MouseLeftButtonDown += AssociatedObject_MouseLeftButtonDown;
            this.AssociatedObject.MouseMove += AssociatedObject_MouseMove;
            this.AssociatedObject.MouseLeftButtonUp += AssociatedObject_MouseLeftButtonUp;
        }

        protected override void OnDetaching()
        {
            base.OnDetaching();

            //分离事件处理程序
            this.AssociatedObject.MouseLeftButtonDown -= AssociatedObject_MouseLeftButtonDown;
            this.AssociatedObject.MouseMove -= AssociatedObject_MouseMove;
            this.AssociatedObject.MouseLeftButtonUp -= AssociatedObject_MouseLeftButtonUp;
        }

        private bool isDragging = false;//拖拽模式
        private Point mouseOffset;//鼠标位置信息

        private void AssociatedObject_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //找到Canvas面板
            if (canvas == null) canvas = VisualTreeHelper.GetParent(this.AssociatedObject) as Canvas;

            //设置拖拽模式
            isDragging = true;

            //获取与点击对象左上角的偏移量
            mouseOffset = e.GetPosition(AssociatedObject);

            //捕获鼠标
            AssociatedObject.CaptureMouse();
        }

        private void AssociatedObject_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)//判断是否开始拖拽
            {
                //找到拖拽对象在面板中的位置
                Point point = e.GetPosition(canvas);

                //移动对象
                AssociatedObject.SetValue(Canvas.TopProperty, point.Y - mouseOffset.Y);
                AssociatedObject.SetValue(Canvas.TopProperty, point.X - mouseOffset.X);
            }
        }

        private void AssociatedObject_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (isDragging)
            {
                //释放鼠标并结束拖拽
                AssociatedObject.ReleaseMouseCapture();
                isDragging = false;
            }
        }
    }
}

