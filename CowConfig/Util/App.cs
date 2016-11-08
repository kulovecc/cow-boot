using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CowConfig.Util
{
    class App
    {
        [DllImport("User32")]
        private static extern int ShowWindow(int hwnd, int nCmdShow);

        private const int SW_HIDE = 0;
        private const int SW_SHOW = 5;

        public String Name { get; private set; }

        private Process process { get; set; }

        public App(Process process)
        {
            this.Name = process.ProcessName;
            this.process = process;
        }

        public void Hide()
        {
            int windowHandle = this.process.MainWindowHandle.ToInt32();
            Console.WriteLine("Hiding {0}: has window handle {1}", this.Name, windowHandle);
            ShowWindow(windowHandle, SW_HIDE);
        }

        public void Show()
        {
            int windowHandle = this.process.MainWindowHandle.ToInt32();
            Console.WriteLine("Showing {0}: has window handle {1}", this.Name, windowHandle);
            ShowWindow(windowHandle, SW_SHOW);

        }

        public static void ShowHandle(int handle)
        {
            Console.WriteLine("Showing window handle {0}", handle);
            ShowWindow(handle, SW_SHOW);
        }
    }
}
