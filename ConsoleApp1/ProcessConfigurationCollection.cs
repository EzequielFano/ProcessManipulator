using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    [ConfigurationCollection(typeof(ProcessConfiguration), AddItemName = "processConfiguration")]
    public class ProcessConfigurationCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new ProcessConfiguration();
        }
        protected override object GetElementKey(ConfigurationElement process)
        {
            return ((ProcessConfiguration)process).NameProcess;
        }
        

    }
}
