using System.Diagnostics;
using System.ServiceProcess;
using Common;

namespace ThermalMonitor
{
    public partial class ThermalAnalytic : ServiceBase
    {
        #region Fields
        IRegistration _regis;

        #endregion

        #region public methods
        public ThermalAnalytic()
        {
            InitializeComponent();

            _regis = new Registration();
            _regis.RegisterLog(Strings.ReportLogSrc, Strings.ReportLogName);
            
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
