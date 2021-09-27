using System;
using System.Linq;
using System.Linq.Dynamic.Core;
using Abp.Linq.Extensions;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using ANZ104AngularDemo.PhoneBook.Exporting;
using ANZ104AngularDemo.PhoneBook.Dtos;
using ANZ104AngularDemo.Dto;
using Abp.Application.Services.Dto;
using ANZ104AngularDemo.Authorization;
using Abp.Extensions;
using Abp.Authorization;
using Microsoft.EntityFrameworkCore;
using Abp.UI;
using ANZ104AngularDemo.Storage;

namespace ANZ104AngularDemo.PhoneBook
{
    [AbpAuthorize(AppPermissions.Pages_Persons)]
    public class PersonsAppService : ANZ104AngularDemoAppServiceBase, IPersonsAppService
    {
        private readonly IRepository<Person> _personRepository;
        private readonly IPersonsExcelExporter _personsExcelExporter;

        public PersonsAppService(IRepository<Person> personRepository, IPersonsExcelExporter personsExcelExporter)
        {
            _personRepository = personRepository;
            _personsExcelExporter = personsExcelExporter;

        }

        public async Task<PagedResultDto<GetPersonForViewDto>> GetAll(GetAllPersonsInput input)
        {

            var filteredPersons = _personRepository.GetAll()
                        .WhereIf(!string.IsNullOrWhiteSpace(input.Filter), e => false || e.PersonName.Contains(input.Filter) || e.PersonEmail.Contains(input.Filter) || e.PersonAddress.Contains(input.Filter))
                        .WhereIf(!string.IsNullOrWhiteSpace(input.PersonNameFilter), e => e.PersonName == input.PersonNameFilter)
                        .WhereIf(!string.IsNullOrWhiteSpace(input.PersonEmailFilter), e => e.PersonEmail == input.PersonEmailFilter)
                        .WhereIf(!string.IsNullOrWhiteSpace(input.PersonAddressFilter), e => e.PersonAddress == input.PersonAddressFilter);

            var pagedAndFilteredPersons = filteredPersons
                .OrderBy(input.Sorting ?? "id asc")
                .PageBy(input);

            var persons = from o in pagedAndFilteredPersons
                          select new
                          {

                              o.PersonName,
                              o.PersonEmail,
                              o.PersonAddress,
                              Id = o.Id
                          };

            var totalCount = await filteredPersons.CountAsync();

            var dbList = await persons.ToListAsync();
            var results = new List<GetPersonForViewDto>();

            foreach (var o in dbList)
            {
                var res = new GetPersonForViewDto()
                {
                    Person = new PersonDto
                    {

                        PersonName = o.PersonName,
                        PersonEmail = o.PersonEmail,
                        PersonAddress = o.PersonAddress,
                        Id = o.Id,
                    }
                };

                results.Add(res);
            }

            return new PagedResultDto<GetPersonForViewDto>(
                totalCount,
                results
            );

        }

        public async Task<GetPersonForViewDto> GetPersonForView(int id)
        {
            var person = await _personRepository.GetAsync(id);

            var output = new GetPersonForViewDto { Person = ObjectMapper.Map<PersonDto>(person) };

            return output;
        }

        [AbpAuthorize(AppPermissions.Pages_Persons_Edit)]
        public async Task<GetPersonForEditOutput> GetPersonForEdit(EntityDto input)
        {
            var person = await _personRepository.FirstOrDefaultAsync(input.Id);

            var output = new GetPersonForEditOutput { Person = ObjectMapper.Map<CreateOrEditPersonDto>(person) };

            return output;
        }

        public async Task CreateOrEdit(CreateOrEditPersonDto input)
        {
            if (input.Id == null)
            {
                await Create(input);
            }
            else
            {
                await Update(input);
            }
        }

        [AbpAuthorize(AppPermissions.Pages_Persons_Create)]
        protected virtual async Task Create(CreateOrEditPersonDto input)
        {
            var person = ObjectMapper.Map<Person>(input);

            if (AbpSession.TenantId != null)
            {
                person.TenantId = (int?)AbpSession.TenantId;
            }

            await _personRepository.InsertAsync(person);

        }

        [AbpAuthorize(AppPermissions.Pages_Persons_Edit)]
        protected virtual async Task Update(CreateOrEditPersonDto input)
        {
            var person = await _personRepository.FirstOrDefaultAsync((int)input.Id);
            ObjectMapper.Map(input, person);

        }

        [AbpAuthorize(AppPermissions.Pages_Persons_Delete)]
        public async Task Delete(EntityDto input)
        {
            await _personRepository.DeleteAsync(input.Id);
        }

        public async Task<FileDto> GetPersonsToExcel(GetAllPersonsForExcelInput input)
        {

            var filteredPersons = _personRepository.GetAll()
                        .WhereIf(!string.IsNullOrWhiteSpace(input.Filter), e => false || e.PersonName.Contains(input.Filter) || e.PersonEmail.Contains(input.Filter) || e.PersonAddress.Contains(input.Filter))
                        .WhereIf(!string.IsNullOrWhiteSpace(input.PersonNameFilter), e => e.PersonName == input.PersonNameFilter)
                        .WhereIf(!string.IsNullOrWhiteSpace(input.PersonEmailFilter), e => e.PersonEmail == input.PersonEmailFilter)
                        .WhereIf(!string.IsNullOrWhiteSpace(input.PersonAddressFilter), e => e.PersonAddress == input.PersonAddressFilter);

            var query = (from o in filteredPersons
                         select new GetPersonForViewDto()
                         {
                             Person = new PersonDto
                             {
                                 PersonName = o.PersonName,
                                 PersonEmail = o.PersonEmail,
                                 PersonAddress = o.PersonAddress,
                                 Id = o.Id
                             }
                         });

            var personListDtos = await query.ToListAsync();

            return _personsExcelExporter.ExportToFile(personListDtos);
        }

    }
}