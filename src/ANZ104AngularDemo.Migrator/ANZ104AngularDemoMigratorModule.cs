using Abp.AspNetZeroCore;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.MicroKernel.Registration;
using Microsoft.Extensions.Configuration;
using ANZ104AngularDemo.Configuration;
using ANZ104AngularDemo.EntityFrameworkCore;
using ANZ104AngularDemo.Migrator.DependencyInjection;

namespace ANZ104AngularDemo.Migrator
{
    [DependsOn(typeof(ANZ104AngularDemoEntityFrameworkCoreModule))]
    public class ANZ104AngularDemoMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public ANZ104AngularDemoMigratorModule(ANZ104AngularDemoEntityFrameworkCoreModule abpZeroTemplateEntityFrameworkCoreModule)
        {
            abpZeroTemplateEntityFrameworkCoreModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(ANZ104AngularDemoMigratorModule).GetAssembly().GetDirectoryPathOrNull(),
                addUserSecrets: true
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                ANZ104AngularDemoConsts.ConnectionStringName
                );
            Configuration.Modules.AspNetZero().LicenseCode = _appConfiguration["AbpZeroLicenseCode"];

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(typeof(IEventBus), () =>
            {
                IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                );
            });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ANZ104AngularDemoMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}