using System.Collections.Generic;
using ANZ104AngularDemo.PhoneBook.Dtos;
using ANZ104AngularDemo.Dto;

namespace ANZ104AngularDemo.PhoneBook.Exporting
{
    public interface IPersonsExcelExporter
    {
        FileDto ExportToFile(List<GetPersonForViewDto> persons);
    }
}