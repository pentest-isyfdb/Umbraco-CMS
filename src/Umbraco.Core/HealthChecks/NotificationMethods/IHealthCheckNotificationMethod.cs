using Umbraco.Cms.Core.Composing;
using System.Threading.Tasks;

namespace Umbraco.Cms.Core.HealthChecks.NotificationMethods;

public interface IHealthCheckNotificationMethod : IDiscoverable
{
    bool Enabled { get; }

    Task SendAsync(HealthCheckResults results);
}