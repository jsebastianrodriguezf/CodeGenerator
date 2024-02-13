namespace SAMMAI.DataBase.Repository.Entities;

public partial class OrtCanalAtencion : OrtCanalAtencionObject
{
    public virtual ICollection<OrtReporteTecnico> OrtReporteTecnicos { get; set; } = new List<OrtReporteTecnico>();
}
