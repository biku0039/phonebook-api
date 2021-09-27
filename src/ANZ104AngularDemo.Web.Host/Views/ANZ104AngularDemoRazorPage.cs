using Abp.AspNetCore.Mvc.Views;

namespace ANZ104AngularDemo.Web.Views
{
    public abstract class ANZ104AngularDemoRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected ANZ104AngularDemoRazorPage()
        {
            LocalizationSourceName = ANZ104AngularDemoConsts.LocalizationSourceName;
        }
    }
}
