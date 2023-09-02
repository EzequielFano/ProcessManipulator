using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Configuration;
using System.Reflection;
using ServiceStack.Text;
using Confluent.Kafka;
using System.IO;
using System.Security.Policy;

namespace ConsoleApp1
{
    public class ProcessManager : ProcessConfigurationSection
    {
        private string _nameProcess;
        private string _path;
        private string _url;
        private int _startUpDelay;
        private int _startMonitor;
        private int _startXPosition;
        private int _startYPosition;
        private int _height;
        private int _width;
        private bool _maximized;
        private bool _minimized;
        private bool _reOpenOnClose;
        private bool _startAutomatically;


        ProcessConfigurationSection processConfigSection = ConfigurationManager.GetSection("processConfigurationSection") as ProcessConfigurationSection;
        public string GetPtocessName
        {
            get {
                foreach (ProcessConfiguration processConfig in processConfigSection.Process)
                {
                    _nameProcess = processConfig.NameProcess;
                }
                return _nameProcess;
                }

        }
        public string Path
        {
            get
            {
                foreach (ProcessConfiguration processConfig in processConfigSection.Process)
                {
                    _path = processConfig.Path;
                }
                return Path;
            }

        }
        public string GetPtocessURL
        {
            get
            {
                foreach (ProcessConfiguration processConfig in processConfigSection.Process)
                {
                    _url = processConfig.URL;
                }
                return _url;
            }

        }
        public int StartUpDelay
        {
            get
            {
                foreach (ProcessConfiguration processConfig in processConfigSection.Process)
                {
                    _startUpDelay = processConfig.StartUpDelay;
                }
                return _startUpDelay;
            }

        }
       


    }
           

}
