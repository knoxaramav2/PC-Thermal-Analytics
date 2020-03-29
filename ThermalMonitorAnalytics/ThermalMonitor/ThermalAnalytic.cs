using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace ThermalMonitor
{
    public partial class ThermalAnalytic : ServiceBase
    {
        #region public methods
        public ThermalAnalytic()
        {
            InitializeComponent();
            RegisterLogs();
            
        }

        #endregion

        #region setup
        private void RegisterLogs()
        {
            reportLog = new EventLog();
        }

        #endregion


        #region events
        protected override void OnStart(string[] args)
        {
        }

        protected override void OnStop()
        {
        }
        #endregion

    }
}
