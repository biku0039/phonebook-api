using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using ANZ104AngularDemo.EntityFrameworkCore;

namespace ANZ104AngularDemo.HealthChecks
{
    public class ANZ104AngularDemoDbContextHealthCheck : IHealthCheck
    {
        private readonly DatabaseCheckHelper _checkHelper;

        public ANZ104AngularDemoDbContextHealthCheck(DatabaseCheckHelper checkHelper)
        {
            _checkHelper = checkHelper;
        }

        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = new CancellationToken())
        {
            if (_checkHelper.Exist("db"))
            {
                return Task.FromResult(HealthCheckResult.Healthy("ANZ104AngularDemoDbContext connected to database."));
            }

            return Task.FromResult(HealthCheckResult.Unhealthy("ANZ104AngularDemoDbContext could not connect to database"));
        }
    }
}
