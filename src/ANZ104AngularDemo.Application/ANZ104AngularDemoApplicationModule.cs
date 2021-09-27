using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ANZ104AngularDemo.Authorization;

namespace ANZ104AngularDemo
{
    /// <summary>
    /// Application layer module of the application.
    /// </summary>
    [DependsOn(
        typeof(ANZ104AngularDemoApplicationSharedModule),
        typeof(ANZ104AngularDemoCoreModule)
        )]
    public class ANZ104AngularDemoApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            //Adding authorization providers
            Configuration.Authorization.Providers.Add<AppAuthorizationProvider>();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ANZ104AngularDemoApplicationModule).GetAssembly());
        }
    }
}