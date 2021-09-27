using System.Collections.Generic;
using ANZ104AngularDemo.Authorization.Users.Importing.Dto;
using ANZ104AngularDemo.Dto;

namespace ANZ104AngularDemo.Authorization.Users.Importing
{
    public interface IInvalidUserExporter
    {
        FileDto ExportToFile(List<ImportUserDto> userListDtos);
    }
}
