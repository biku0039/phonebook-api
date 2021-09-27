using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ANZ104AngularDemo.Configuration;
using ANZ104AngularDemo.Web;

namespace ANZ104AngularDemo.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ANZ104AngularDemoDbContextFactory : IDesignTimeDbContextFactory<ANZ104AngularDemoDbContext>
    {
        public ANZ104AngularDemoDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ANZ104AngularDemoDbContext>();

            /*
             You can provide an environmentName parameter to the AppConfigurations.Get method. 
             In this case, AppConfigurations will try to read appsettings.{environmentName}.json.
             Use Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") method or from string[] args to get environment if necessary.
             https://docs.microsoft.com/en-us/ef/core/cli/dbcontext-creation?tabs=dotnet-core-cli#args
             */
            var configuration = AppConfigurations.Get(
                WebContentDirectoryFinder.CalculateContentRootFolder(),
                addUserSecrets: true
            );

            ANZ104AngularDemoDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ANZ104AngularDemoConsts.ConnectionStringName));

            return new ANZ104AngularDemoDbContext(builder.Options);
        }
    }
}
