using NUGET.BOBERTO.PACKAGE.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUGET.BOBERTO.PACKAGE.Services.HealhCheck
{
    public interface IHealthCheck
    {
        TimeSpan GetUpTime();
        HealthCheckSerializable GetSerializableMessage();
    }
}
