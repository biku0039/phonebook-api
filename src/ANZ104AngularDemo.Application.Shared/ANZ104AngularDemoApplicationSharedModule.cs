using Abp.Modules;
using Abp.Reflection.Extensions;

namespace ANZ104AngularDemo
{
    [DependsOn(typeof(ANZ104AngularDemoCoreSharedModule))]
    public class ANZ104AngularDemoApplicationSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ANZ104AngularDemoApplicationSharedModule).GetAssembly());
        }
    }
}