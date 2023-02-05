using NUGET.BOBERTO.PACKAGE.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUGET.BOBERTO.PACKAGE.Services.BobertoHealthCheck
{
    public interface IBobertoHealthCheck
    {
        TimeSpan GetUpTime();
        HealthCheckSerializable GetSerializableMessage();
    }
}
