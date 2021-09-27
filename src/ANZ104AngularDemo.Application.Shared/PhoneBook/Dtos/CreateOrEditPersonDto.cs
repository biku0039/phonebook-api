using System;
using Abp.Application.Services.Dto;
using System.ComponentModel.DataAnnotations;

namespace ANZ104AngularDemo.PhoneBook.Dtos
{
    public class CreateOrEditPersonDto : EntityDto<int?>
    {

        [Required]
        public string PersonName { get; set; }

        [Required]
        public string PersonEmail { get; set; }

        public string PersonAddress { get; set; }

    }
}