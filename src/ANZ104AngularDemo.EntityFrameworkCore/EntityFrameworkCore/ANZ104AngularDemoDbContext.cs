using ANZ104AngularDemo.PhoneBook;
using Abp.IdentityServer4vNext;
using Abp.Zero.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ANZ104AngularDemo.Authorization.Delegation;
using ANZ104AngularDemo.Authorization.Roles;
using ANZ104AngularDemo.Authorization.Users;
using ANZ104AngularDemo.Chat;
using ANZ104AngularDemo.Editions;
using ANZ104AngularDemo.Friendships;
using ANZ104AngularDemo.MultiTenancy;
using ANZ104AngularDemo.MultiTenancy.Accounting;
using ANZ104AngularDemo.MultiTenancy.Payments;
using ANZ104AngularDemo.Storage;

namespace ANZ104AngularDemo.EntityFrameworkCore
{
    public class ANZ104AngularDemoDbContext : AbpZeroDbContext<Tenant, Role, User, ANZ104AngularDemoDbContext>, IAbpPersistedGrantDbContext
    {
        public virtual DbSet<Person> Persons { get; set; }

        /* Define an IDbSet for each entity of the application */

        public virtual DbSet<BinaryObject> BinaryObjects { get; set; }

        public virtual DbSet<Friendship> Friendships { get; set; }

        public virtual DbSet<ChatMessage> ChatMessages { get; set; }

        public virtual DbSet<SubscribableEdition> SubscribableEditions { get; set; }

        public virtual DbSet<SubscriptionPayment> SubscriptionPayments { get; set; }

        public virtual DbSet<Invoice> Invoices { get; set; }

        public virtual DbSet<PersistedGrantEntity> PersistedGrants { get; set; }

        public virtual DbSet<SubscriptionPaymentExtensionData> SubscriptionPaymentExtensionDatas { get; set; }

        public virtual DbSet<UserDelegation> UserDelegations { get; set; }

        public ANZ104AngularDemoDbContext(DbContextOptions<ANZ104AngularDemoDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Person>(p =>
            {
                p.HasIndex(e => new { e.TenantId });
            });
            modelBuilder.Entity<BinaryObject>(b =>
                       {
                           b.HasIndex(e => new { e.TenantId });
                       });

            modelBuilder.Entity<ChatMessage>(b =>
            {
                b.HasIndex(e => new { e.TenantId, e.UserId, e.ReadState });
                b.HasIndex(e => new { e.TenantId, e.TargetUserId, e.ReadState });
                b.HasIndex(e => new { e.TargetTenantId, e.TargetUserId, e.ReadState });
                b.HasIndex(e => new { e.TargetTenantId, e.UserId, e.ReadState });
            });

            modelBuilder.Entity<Friendship>(b =>
            {
                b.HasIndex(e => new { e.TenantId, e.UserId });
                b.HasIndex(e => new { e.TenantId, e.FriendUserId });
                b.HasIndex(e => new { e.FriendTenantId, e.UserId });
                b.HasIndex(e => new { e.FriendTenantId, e.FriendUserId });
            });

            modelBuilder.Entity<Tenant>(b =>
            {
                b.HasIndex(e => new { e.SubscriptionEndDateUtc });
                b.HasIndex(e => new { e.CreationTime });
            });

            modelBuilder.Entity<SubscriptionPayment>(b =>
            {
                b.HasIndex(e => new { e.Status, e.CreationTime });
                b.HasIndex(e => new { PaymentId = e.ExternalPaymentId, e.Gateway });
            });

            modelBuilder.Entity<SubscriptionPaymentExtensionData>(b =>
            {
                b.HasQueryFilter(m => !m.IsDeleted)
                    .HasIndex(e => new { e.SubscriptionPaymentId, e.Key, e.IsDeleted })
                    .IsUnique();
            });

            modelBuilder.Entity<UserDelegation>(b =>
            {
                b.HasIndex(e => new { e.TenantId, e.SourceUserId });
                b.HasIndex(e => new { e.TenantId, e.TargetUserId });
            });

            modelBuilder.ConfigurePersistedGrantEntity();
        }
    }
}