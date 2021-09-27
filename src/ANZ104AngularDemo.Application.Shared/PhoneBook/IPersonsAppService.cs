using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ANZ104AngularDemo.PhoneBook.Dtos;
using ANZ104AngularDemo.Dto;

namespace ANZ104AngularDemo.PhoneBook
{
    public interface IPersonsAppService : IApplicationService
    {
        Task<PagedResultDto<GetPersonForViewDto>> GetAll(GetAllPersonsInput input);

        Task<GetPersonForViewDto> GetPersonForView(int id);

        Task<GetPersonForEditOutput> GetPersonForEdit(EntityDto input);

        Task CreateOrEdit(CreateOrEditPersonDto input);

        Task Delete(EntityDto input);

        Task<FileDto> GetPersonsToExcel(GetAllPersonsForExcelInput input);

    }
}