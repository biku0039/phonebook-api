using Abp.Dependency;
using Abp.Reflection.Extensions;
using Microsoft.Extensions.Configuration;
using ANZ104AngularDemo.Configuration;

namespace ANZ104AngularDemo.Test.Base
{
    public class TestAppConfigurationAccessor : IAppConfigurationAccessor, ISingletonDependency
    {
        public IConfigurationRoot Configuration { get; }

        public TestAppConfigurationAccessor()
        {
            Configuration = AppConfigurations.Get(
                typeof(ANZ104AngularDemoTestBaseModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }
    }
}
