using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace ANZ104AngularDemo.Web.Public.Views
{
    public abstract class ANZ104AngularDemoRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected ANZ104AngularDemoRazorPage()
        {
            LocalizationSourceName = ANZ104AngularDemoConsts.LocalizationSourceName;
        }
    }
}
