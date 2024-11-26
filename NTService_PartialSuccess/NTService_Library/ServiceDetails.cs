using System;

namespace NTService_Library
{
    public class ServiceDetails
    {
        string _serviceName;
        public ServiceDetails(string ServiceName)
        {
            this._serviceName = ServiceName;
        }

        public string GetServiceName()
        {
            return this._serviceName;
        }

        public string GetServiceDescription()
        {
            return "Windows NT 3.51 is a major release of the Windows NT operating system developed by Microsoft and oriented towards businesses. It is the third version of Windows NT and was released on May 30, 1995, eight months following the release of Windows NT 3.5.";
        }
    }
}
