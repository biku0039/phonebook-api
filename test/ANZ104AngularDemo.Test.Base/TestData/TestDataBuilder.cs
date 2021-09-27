using ANZ104AngularDemo.EntityFrameworkCore;

namespace ANZ104AngularDemo.Test.Base.TestData
{
    public class TestDataBuilder
    {
        private readonly ANZ104AngularDemoDbContext _context;
        private readonly int _tenantId;

        public TestDataBuilder(ANZ104AngularDemoDbContext context, int tenantId)
        {
            _context = context;
            _tenantId = tenantId;
        }

        public void Create()
        {
            new TestOrganizationUnitsBuilder(_context, _tenantId).Create();
            new TestSubscriptionPaymentBuilder(_context, _tenantId).Create();
            new TestEditionsBuilder(_context).Create();

            _context.SaveChanges();
        }
    }
}
