namespace SAMMAI.DataBase.Repository.Entities;

public partial class DocDocumentoGasto : DocDocumentoGastoObject
{
    public virtual DocDocumento IdNavigation { get; set; } = null!;
    public virtual ICollection<OrtReporteTecnico> OrtReporteTecnicos { get; set; } = new List<OrtReporteTecnico>();
}
