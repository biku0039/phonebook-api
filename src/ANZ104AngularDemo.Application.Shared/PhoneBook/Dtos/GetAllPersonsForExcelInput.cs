using Abp.Application.Services.Dto;
using System;

namespace ANZ104AngularDemo.PhoneBook.Dtos
{
    public class GetAllPersonsForExcelInput
    {
        public string Filter { get; set; }

        public string PersonNameFilter { get; set; }

        public string PersonEmailFilter { get; set; }

        public string PersonAddressFilter { get; set; }

    }
}