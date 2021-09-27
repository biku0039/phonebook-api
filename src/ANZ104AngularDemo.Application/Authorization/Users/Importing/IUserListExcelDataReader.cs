using System.Collections.Generic;
using ANZ104AngularDemo.Authorization.Users.Importing.Dto;
using Abp.Dependency;

namespace ANZ104AngularDemo.Authorization.Users.Importing
{
    public interface IUserListExcelDataReader: ITransientDependency
    {
        List<ImportUserDto> GetUsersFromExcel(byte[] fileBytes);
    }
}
