using NTService_Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace NTService_PartialSuccess
{
    public partial class Service1 : ServiceBase
    {
        NTService_Library.ServiceDetails _serviceDetails = null;
        
        public Service1()
        {
            InitializeComponent();
            _serviceDetails = new ServiceDetails("NT_Serivce");
            EventLog.CreateEventSource(_serviceDetails.GetServiceName(), "Application");
        }

        protected override void OnStart(string[] args)
        {
            EventLog.WriteEntry(_serviceDetails.GetServiceName(), "Started", EventLogEntryType.Information);
        }

        protected override void OnStop()
        {
            EventLog.WriteEntry(_serviceDetails.GetServiceName(), "Stopped", EventLogEntryType.Information);
        }
    }
}
