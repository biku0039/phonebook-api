using System.Collections.Generic;
using Abp.Runtime.Session;
using Abp.Timing.Timezone;
using ANZ104AngularDemo.DataExporting.Excel.NPOI;
using ANZ104AngularDemo.PhoneBook.Dtos;
using ANZ104AngularDemo.Dto;
using ANZ104AngularDemo.Storage;

namespace ANZ104AngularDemo.PhoneBook.Exporting
{
    public class PersonsExcelExporter : NpoiExcelExporterBase, IPersonsExcelExporter
    {

        private readonly ITimeZoneConverter _timeZoneConverter;
        private readonly IAbpSession _abpSession;

        public PersonsExcelExporter(
            ITimeZoneConverter timeZoneConverter,
            IAbpSession abpSession,
            ITempFileCacheManager tempFileCacheManager) :
    base(tempFileCacheManager)
        {
            _timeZoneConverter = timeZoneConverter;
            _abpSession = abpSession;
        }

        public FileDto ExportToFile(List<GetPersonForViewDto> persons)
        {
            return CreateExcelPackage(
                "Persons.xlsx",
                excelPackage =>
                {

                    var sheet = excelPackage.CreateSheet(L("Persons"));

                    AddHeader(
                        sheet,
                        L("PersonName"),
                        L("PersonEmail"),
                        L("PersonAddress")
                        );

                    AddObjects(
                        sheet, persons,
                        _ => _.Person.PersonName,
                        _ => _.Person.PersonEmail,
                        _ => _.Person.PersonAddress
                        );

                });
        }
    }
}