using System.Data.SqlClient;
using Shouldly;
using Xunit;

namespace ANZ104AngularDemo.Tests.General
{
    // ReSharper disable once InconsistentNaming
    public class ConnectionString_Tests
    {
        [Fact]
        public void SqlConnectionStringBuilder_Test()
        {
            var csb = new SqlConnectionStringBuilder("Server=localhost; Database=ANZ104AngularDemo; Trusted_Connection=True;");
            csb["Database"].ShouldBe("ANZ104AngularDemo");
        }
    }
}
