using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThermalMonitor
{
    interface IRegistration 
    {
        bool RegisterLog(string src, string name);
    }


    class Registration : IRegistration
    {
        public bool RegisterLog(string src, string name)
        {
            var reportLog = new EventLog();
            if (!EventLog.SourceExists(src))
            {
                EventLog.CreateEventSource(
                    src,
                    name);
            }
            reportLog.Source = "";
            reportLog.Log = "";

            return true;
        }
    }
}
