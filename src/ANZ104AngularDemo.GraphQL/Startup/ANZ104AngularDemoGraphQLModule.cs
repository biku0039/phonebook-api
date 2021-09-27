using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace ANZ104AngularDemo.Startup
{
    [DependsOn(typeof(ANZ104AngularDemoCoreModule))]
    public class ANZ104AngularDemoGraphQLModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ANZ104AngularDemoGraphQLModule).GetAssembly());
        }

        public override void PreInitialize()
        {
            base.PreInitialize();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }
    }
}