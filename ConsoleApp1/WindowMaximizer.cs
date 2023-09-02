using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class WindowMaximizer
    {
        [DllImport("user32.dll")]
        public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        public void MaximizeProcessWindows(Process[] processes) 
        {
            
            if (processes.Length > 0)
            {
                foreach (Process Process in processes)
                {
                    IntPtr hWnd = Process.MainWindowHandle;
                    if (hWnd != IntPtr.Zero)
                    {
                        // Maximiza la ventana de Word
                        ShowWindow(hWnd, 9); // 3 = SW_MAXIMIZE
                        ShowWindow(hWnd, 3);
                    }
                }
            }
            else
            {
                Console.WriteLine("No se encontraron procesos de Microsoft Word abiertos.");
            }
        }
    }
}
