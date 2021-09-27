using Abp.Domain.Services;

namespace ANZ104AngularDemo
{
    public abstract class ANZ104AngularDemoDomainServiceBase : DomainService
    {
        /* Add your common members for all your domain services. */

        protected ANZ104AngularDemoDomainServiceBase()
        {
            LocalizationSourceName = ANZ104AngularDemoConsts.LocalizationSourceName;
        }
    }
}
