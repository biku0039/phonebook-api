using System.Collections.Generic;
using ANZ104AngularDemo.Auditing.Dto;
using ANZ104AngularDemo.Dto;

namespace ANZ104AngularDemo.Auditing.Exporting
{
    public interface IAuditLogListExcelExporter
    {
        FileDto ExportToFile(List<AuditLogListDto> auditLogListDtos);

        FileDto ExportToFile(List<EntityChangeListDto> entityChangeListDtos);
    }
}
