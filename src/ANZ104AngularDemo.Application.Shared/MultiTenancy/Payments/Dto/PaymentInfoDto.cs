using ANZ104AngularDemo.Editions.Dto;

namespace ANZ104AngularDemo.MultiTenancy.Payments.Dto
{
    public class PaymentInfoDto
    {
        public EditionSelectDto Edition { get; set; }

        public decimal AdditionalPrice { get; set; }

        public bool IsLessThanMinimumUpgradePaymentAmount()
        {
            return AdditionalPrice < ANZ104AngularDemoConsts.MinimumUpgradePaymentAmount;
        }
    }
}
