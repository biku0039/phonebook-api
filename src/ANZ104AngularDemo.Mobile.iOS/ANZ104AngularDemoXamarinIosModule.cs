using Abp.Modules;
using Abp.Reflection.Extensions;

namespace ANZ104AngularDemo
{
    [DependsOn(typeof(ANZ104AngularDemoXamarinSharedModule))]
    public class ANZ104AngularDemoXamarinIosModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ANZ104AngularDemoXamarinIosModule).GetAssembly());
        }
    }
}