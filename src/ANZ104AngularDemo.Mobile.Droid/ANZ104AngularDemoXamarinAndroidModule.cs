using Abp.Modules;
using Abp.Reflection.Extensions;

namespace ANZ104AngularDemo
{
    [DependsOn(typeof(ANZ104AngularDemoXamarinSharedModule))]
    public class ANZ104AngularDemoXamarinAndroidModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ANZ104AngularDemoXamarinAndroidModule).GetAssembly());
        }
    }
}