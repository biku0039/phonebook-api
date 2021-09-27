using System;
using Abp.Application.Services.Dto;

namespace ANZ104AngularDemo.PhoneBook.Dtos
{
    public class PersonDto : EntityDto
    {
        public string PersonName { get; set; }

        public string PersonEmail { get; set; }

        public string PersonAddress { get; set; }

    }
}