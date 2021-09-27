using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ANZ104AngularDemo.EntityFrameworkCore
{
    public static class ANZ104AngularDemoDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ANZ104AngularDemoDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ANZ104AngularDemoDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}