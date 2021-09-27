using System.Threading.Tasks;
using Abp.Application.Services;

namespace ANZ104AngularDemo.MultiTenancy
{
    public interface ISubscriptionAppService : IApplicationService
    {
        Task DisableRecurringPayments();

        Task EnableRecurringPayments();
    }
}
