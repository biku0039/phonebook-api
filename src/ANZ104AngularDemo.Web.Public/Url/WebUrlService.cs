using Abp.Dependency;
using ANZ104AngularDemo.Configuration;
using ANZ104AngularDemo.Url;
using ANZ104AngularDemo.Web.Url;

namespace ANZ104AngularDemo.Web.Public.Url
{
    public class WebUrlService : WebUrlServiceBase, IWebUrlService, ITransientDependency
    {
        public WebUrlService(
            IAppConfigurationAccessor appConfigurationAccessor) :
            base(appConfigurationAccessor)
        {
        }

        public override string WebSiteRootAddressFormatKey => "App:WebSiteRootAddress";

        public override string ServerRootAddressFormatKey => "App:AdminWebSiteRootAddress";
    }
}