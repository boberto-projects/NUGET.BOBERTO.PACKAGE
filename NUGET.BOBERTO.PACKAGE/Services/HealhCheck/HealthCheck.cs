using NUGET.BOBERTO.PACKAGE.Messages;
using System;

namespace NUGET.BOBERTO.PACKAGE.Services.HealhCheck
{
    public class HealthCheck : IHealthCheck
    {
        public DateTime StartAt { get; set; }
        public TimeSpan LastDeploy { get; set; }
        public string Environment { get; set; }
        public string ProjectName { get; set; }
        public HealthCheck()
        {
            StartAt = DateTime.Now;
            Environment = System.Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "PRODUCTION";
        }
        public HealthCheck(string projectName)
        {
            StartAt = DateTime.Now;
            ProjectName = projectName;
            Environment = System.Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "PRODUCTION";
        }
        public TimeSpan GetUpTime()
        {
            var upTime = DateTime.Now.Subtract(StartAt);
            LastDeploy = upTime;
            return upTime;
        }
        public HealthCheckSerializable GetSerializableMessage()
        {
            return new HealthCheckSerializable()
            {
                LastDeploy = LastDeploy,
                Environment = Environment,
                ProjectName = ProjectName,
                StartAt = StartAt
            };
        }
    }
}
