using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ProcessConfigurationSection : ConfigurationSection
    {
        [ConfigurationProperty("Process", IsDefaultCollection = true)]
        public ProcessConfigurationCollection Process
        {
            get { return (ProcessConfigurationCollection)this["Process"]; }
            set { this["Process"] = value; }
        }
       
    }
}
