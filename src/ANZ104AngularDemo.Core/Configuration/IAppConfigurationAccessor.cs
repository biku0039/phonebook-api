using Microsoft.Extensions.Configuration;

namespace ANZ104AngularDemo.Configuration
{
    public interface IAppConfigurationAccessor
    {
        IConfigurationRoot Configuration { get; }
    }
}
