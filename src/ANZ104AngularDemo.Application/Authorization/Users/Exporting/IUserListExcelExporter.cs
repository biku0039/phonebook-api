using System.Collections.Generic;
using ANZ104AngularDemo.Authorization.Users.Dto;
using ANZ104AngularDemo.Dto;

namespace ANZ104AngularDemo.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}