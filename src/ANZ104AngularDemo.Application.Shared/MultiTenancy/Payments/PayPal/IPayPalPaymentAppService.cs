using System.Threading.Tasks;
using Abp.Application.Services;
using ANZ104AngularDemo.MultiTenancy.Payments.PayPal.Dto;

namespace ANZ104AngularDemo.MultiTenancy.Payments.PayPal
{
    public interface IPayPalPaymentAppService : IApplicationService
    {
        Task ConfirmPayment(long paymentId, string paypalOrderId);

        PayPalConfigurationDto GetConfiguration();
    }
}
