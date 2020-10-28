using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _21.Single_Instance_Application
{
    class Startup
    {
        [STAThread]//设置单线程

        public static void Main(string[] args)
        {
            //WPFapp app = new WPFapp();
            //app.Run();

            SingleInstanceAppWrapper appwrapper = new SingleInstanceAppWrapper();
            appwrapper.Run(args);
        }
    }
}
