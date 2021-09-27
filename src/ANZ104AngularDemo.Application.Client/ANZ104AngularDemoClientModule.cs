using Abp.Modules;
using Abp.Reflection.Extensions;

namespace ANZ104AngularDemo
{
    public class ANZ104AngularDemoClientModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ANZ104AngularDemoClientModule).GetAssembly());
        }
    }
}
