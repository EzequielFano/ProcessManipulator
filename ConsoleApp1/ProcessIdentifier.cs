using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Configuration;
using System.Data.SqlTypes;

namespace ConsoleApp1
{
    public class ProcessIdentifier
    {
        public Process[] FindProcesses(string name)
        {
            return Process.GetProcessesByName(name);
        }
    }
}
