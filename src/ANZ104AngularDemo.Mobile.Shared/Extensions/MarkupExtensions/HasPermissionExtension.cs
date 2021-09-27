using System;
using ANZ104AngularDemo.Core;
using ANZ104AngularDemo.Core.Dependency;
using ANZ104AngularDemo.Services.Permission;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ANZ104AngularDemo.Extensions.MarkupExtensions
{
    [ContentProperty("Text")]
    public class HasPermissionExtension : IMarkupExtension
    {
        public string Text { get; set; }
        
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (ApplicationBootstrapper.AbpBootstrapper == null || Text == null)
            {
                return false;
            }

            var permissionService = DependencyResolver.Resolve<IPermissionService>();
            return permissionService.HasPermission(Text);
        }
    }
}