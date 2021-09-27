using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;
using Abp.Domain.Entities;

namespace ANZ104AngularDemo.PhoneBook
{
    [Table("Persons")]
    public class Person : Entity, IMayHaveTenant
    {
        public int? TenantId { get; set; }

        [Required]
        public virtual string PersonName { get; set; }

        [Required]
        public virtual string PersonEmail { get; set; }

        public virtual string PersonAddress { get; set; }

    }
}