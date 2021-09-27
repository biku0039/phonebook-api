using Abp.AspNetCore.Mvc.ViewComponents;

namespace ANZ104AngularDemo.Web.Public.Views
{
    public abstract class ANZ104AngularDemoViewComponent : AbpViewComponent
    {
        protected ANZ104AngularDemoViewComponent()
        {
            LocalizationSourceName = ANZ104AngularDemoConsts.LocalizationSourceName;
        }
    }
}