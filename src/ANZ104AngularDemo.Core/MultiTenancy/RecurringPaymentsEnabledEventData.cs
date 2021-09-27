using Abp.Events.Bus;

namespace ANZ104AngularDemo.MultiTenancy
{
    public class RecurringPaymentsEnabledEventData : EventData
    {
        public int TenantId { get; set; }
    }
}