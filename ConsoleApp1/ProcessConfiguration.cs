using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ProcessConfiguration : ConfigurationSection
    {
        [ConfigurationProperty("NameProcess", DefaultValue = "", IsKey = true, IsRequired = true)]
        public string NameProcess
        {
            get { return (string)this["NameProcess"]; }
            set { this["NameProcess"] = value; }
        }

        [ConfigurationProperty("Path", DefaultValue = "", IsKey = true, IsRequired = true)]
        public string Path 
        {
            get { return (string)this["Path"]; }
            set { this["Path"] = value; }
        }

        [ConfigurationProperty("URL", DefaultValue = "", IsKey = true, IsRequired = true)]
        public string URL
        {
            get { return (string)this["URL"]; }
            set { this["URL"] = value; }
        }

        [ConfigurationProperty("StartUpDelay", DefaultValue = 0, IsKey = true, IsRequired = true)]
        public int StartUpDelay
        {
            get { return (int)this["StartUpDelay"]; }
            set { this["StartUpDelay"] = value; }
        }

        [ConfigurationProperty("StartMonitor", DefaultValue = 0, IsKey = true, IsRequired = true)]
        public int StartMonitor
        {
            get { return (int)this["StartMonitor"]; }
            set { this["StartMonitor"] = value; }
        }

        [ConfigurationProperty("StartXPosition", DefaultValue = 0, IsKey = true, IsRequired = true)]
        public int StartXPosition
        {
            get { return (int)this["StartXPosition"]; }
            set { this["StartXPosition"] = value; }
        }

        [ConfigurationProperty("StartYPosition", DefaultValue = 0, IsKey = true, IsRequired = true)]
        public int StartYPosition
        {
            get { return (int)this["StartYPosition"]; }
            set { this["StartYPosition"] = value; }
        }

        [ConfigurationProperty("Height", DefaultValue = 0, IsKey = true, IsRequired = true)]
        public int Height
        {
            get { return (int)this["Height"]; }
            set { this["Height"] = value; }
        }

        [ConfigurationProperty("Width", DefaultValue = 0, IsKey = true, IsRequired = true)]
        public int Width
        {
            get { return (int)this["Width"]; }
            set { this["Width"] = value; }
        }

        [ConfigurationProperty("Maximized", DefaultValue = false, IsKey = true, IsRequired = true)]
        public bool Maximized
        {
            get { return (bool)this["Maximized"]; }
            set { this["Maximized"] = value; }
        }

        [ConfigurationProperty("Minimized", DefaultValue = false, IsKey = true, IsRequired = true)]
        public bool Minimized
        {
            get { return (bool)this["Minimized"]; }
            set { this["Minimized"] = value; }
        }

        [ConfigurationProperty("ReOpenOnClose", DefaultValue = false, IsKey = true, IsRequired = true)]
        public bool ReOpenOnClose
        {
            get { return (bool)this["ReOpenOnClose"]; }
            set { this["ReOpenOnClose"] = value; }
        }

        [ConfigurationProperty("StartAutomatically", DefaultValue = false, IsKey = true, IsRequired = true)]
        public bool StartAutomatically
        {
            get { return (bool)this["StartAutomatically"]; }
            set { this["StartAutomatically"] = value; }
        }

    }
}
