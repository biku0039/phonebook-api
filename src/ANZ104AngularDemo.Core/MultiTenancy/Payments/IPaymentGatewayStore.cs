using System.Collections.Generic;

namespace ANZ104AngularDemo.MultiTenancy.Payments
{
    public interface IPaymentGatewayStore
    {
        List<PaymentGatewayModel> GetActiveGateways();
    }
}
