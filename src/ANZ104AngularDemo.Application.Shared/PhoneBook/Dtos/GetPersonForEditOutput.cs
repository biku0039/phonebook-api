using System;
using Abp.Application.Services.Dto;
using System.ComponentModel.DataAnnotations;

namespace ANZ104AngularDemo.PhoneBook.Dtos
{
    public class GetPersonForEditOutput
    {
        public CreateOrEditPersonDto Person { get; set; }

    }
}