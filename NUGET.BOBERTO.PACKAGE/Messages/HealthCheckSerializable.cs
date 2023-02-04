using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUGET.BOBERTO.PACKAGE.Messages
{
    public class HealthCheckSerializable
    {
        public DateTime StartAt { get; set; }
        public TimeSpan LastDeploy { get; set; }
        public string Environment { get; set; }
        public string ProjectName { get; set; }

    }
}
