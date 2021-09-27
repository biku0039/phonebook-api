using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace ANZ104AngularDemo
{
    [DependsOn(typeof(ANZ104AngularDemoClientModule), typeof(AbpAutoMapperModule))]
    public class ANZ104AngularDemoXamarinSharedModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Localization.IsEnabled = false;
            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ANZ104AngularDemoXamarinSharedModule).GetAssembly());
        }
    }
}