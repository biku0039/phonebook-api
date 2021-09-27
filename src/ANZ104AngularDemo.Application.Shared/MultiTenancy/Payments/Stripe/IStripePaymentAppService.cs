﻿using System.Threading.Tasks;
using Abp.Application.Services;
using ANZ104AngularDemo.MultiTenancy.Payments.Dto;
using ANZ104AngularDemo.MultiTenancy.Payments.Stripe.Dto;

namespace ANZ104AngularDemo.MultiTenancy.Payments.Stripe
{
    public interface IStripePaymentAppService : IApplicationService
    {
        Task ConfirmPayment(StripeConfirmPaymentInput input);

        StripeConfigurationDto GetConfiguration();

        Task<SubscriptionPaymentDto> GetPaymentAsync(StripeGetPaymentInput input);

        Task<string> CreatePaymentSession(StripeCreatePaymentSessionInput input);
    }
}