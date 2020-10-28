using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _21.Single_Instance_Application
{
    class SingleInstanceAppWrapper : Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase
    {
        //设置是否为单实例应用程序
        public SingleInstanceAppWrapper()
        {
            IsSingleInstance = true;
        }

        private WPFapp app;

        //重写Onstartup事件的处理方法
        protected override bool OnStartup(Microsoft.VisualBasic.ApplicationServices.StartupEventArgs eventArgs)
        {
            app = new WPFapp();
            app.Run();
            return false;
        }
        
        //重写新增程序时的响应事件
        protected override void OnStartupNextInstance(Microsoft.VisualBasic.ApplicationServices.StartupNextInstanceEventArgs eventArgs)
        {
            base.OnStartupNextInstance(eventArgs);

            app.showWindow();
        }
    }
}
