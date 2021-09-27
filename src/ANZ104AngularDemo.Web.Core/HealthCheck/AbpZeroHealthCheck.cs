using Microsoft.Extensions.DependencyInjection;
using ANZ104AngularDemo.HealthChecks;

namespace ANZ104AngularDemo.Web.HealthCheck
{
    public static class AbpZeroHealthCheck
    {
        public static IHealthChecksBuilder AddAbpZeroHealthCheck(this IServiceCollection services)
        {
            var builder = services.AddHealthChecks();
            builder.AddCheck<ANZ104AngularDemoDbContextHealthCheck>("Database Connection");
            builder.AddCheck<ANZ104AngularDemoDbContextUsersHealthCheck>("Database Connection with user check");
            builder.AddCheck<CacheHealthCheck>("Cache");

            // add your custom health checks here
            // builder.AddCheck<MyCustomHealthCheck>("my health check");

            return builder;
        }
    }
}
