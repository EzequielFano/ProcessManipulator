using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Configuration;
using System.Reflection;

namespace ConsoleApp1
{
    class Program : ProcessConfigurationSection
    {
          
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------------------------------");
            ProcessManager manager = new ProcessManager();
            
            Console.WriteLine(manager.GetPtocessName);
            Console.Write(manager.GetPtocessURL);  

            Console.ReadLine(); 
        }
    }
}
