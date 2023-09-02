using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MySectionGroup : ConfigurationSectionGroup
    {
        [ConfigurationProperty("processConfigurationSection", IsRequired = false)]
        public ProcessConfigurationSection GeneralSettings
        {
            get { return (ProcessConfigurationSection)base.Sections["processConfigurationSection"]; }
        }
    }
}
