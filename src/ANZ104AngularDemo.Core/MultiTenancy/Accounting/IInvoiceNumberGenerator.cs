using System.Threading.Tasks;
using Abp.Dependency;

namespace ANZ104AngularDemo.MultiTenancy.Accounting
{
    public interface IInvoiceNumberGenerator : ITransientDependency
    {
        Task<string> GetNewInvoiceNumber();
    }
}