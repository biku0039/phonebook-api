using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.Windsor.MsDependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using ANZ104AngularDemo.Configure;
using ANZ104AngularDemo.Startup;
using ANZ104AngularDemo.Test.Base;

namespace ANZ104AngularDemo.GraphQL.Tests
{
    [DependsOn(
        typeof(ANZ104AngularDemoGraphQLModule),
        typeof(ANZ104AngularDemoTestBaseModule))]
    public class ANZ104AngularDemoGraphQLTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            IServiceCollection services = new ServiceCollection();
            
            services.AddAndConfigureGraphQL();

            WindsorRegistrationHelper.CreateServiceProvider(IocManager.IocContainer, services);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ANZ104AngularDemoGraphQLTestModule).GetAssembly());
        }
    }
}