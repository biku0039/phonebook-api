using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using ANZ104AngularDemo.MultiTenancy.Accounting.Dto;

namespace ANZ104AngularDemo.MultiTenancy.Accounting
{
    public interface IInvoiceAppService
    {
        Task<InvoiceDto> GetInvoiceInfo(EntityDto<long> input);

        Task CreateInvoice(CreateInvoiceDto input);
    }
}
