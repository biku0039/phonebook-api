using Abp.Application.Services.Dto;

namespace ANZ104AngularDemo.PhoneBook.Dtos
{
    public class GetAllForLookupTableInput : PagedAndSortedResultRequestDto
    {
        public string Filter { get; set; }
    }
}