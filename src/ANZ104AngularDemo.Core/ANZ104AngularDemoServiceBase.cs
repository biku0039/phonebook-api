using Abp;

namespace ANZ104AngularDemo
{
    /// <summary>
    /// This class can be used as a base class for services in this application.
    /// It has some useful objects property-injected and has some basic methods most of services may need to.
    /// It's suitable for non domain nor application service classes.
    /// For domain services inherit <see cref="ANZ104AngularDemoDomainServiceBase"/>.
    /// For application services inherit ANZ104AngularDemoAppServiceBase.
    /// </summary>
    public abstract class ANZ104AngularDemoServiceBase : AbpServiceBase
    {
        protected ANZ104AngularDemoServiceBase()
        {
            LocalizationSourceName = ANZ104AngularDemoConsts.LocalizationSourceName;
        }
    }
}