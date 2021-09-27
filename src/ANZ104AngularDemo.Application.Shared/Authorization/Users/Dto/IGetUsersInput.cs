using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Abp.Runtime.Validation;

namespace ANZ104AngularDemo.Authorization.Users.Dto
{
    public interface IGetUsersInput : ISortedResultRequest
    {
        string Filter { get; set; }

        List<string> Permissions { get; set; }

        int? Role { get; set; }

        bool OnlyLockedUsers { get; set; }
    }
}
