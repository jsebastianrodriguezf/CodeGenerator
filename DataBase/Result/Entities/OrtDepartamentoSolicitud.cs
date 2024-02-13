namespace SAMMAI.DataBase.Repository.Entities;

public partial class OrtDepartamentoSolicitud : OrtDepartamentoSolicitudObject
{
    public virtual ICollection<CntContrato> CntContratos { get; set; } = new List<CntContrato>();
    public virtual ICollection<DocDocumentoOt> DocDocumentoOts { get; set; } = new List<DocDocumentoOt>();
    public virtual ICollection<DocDocumentoSolicitud> DocDocumentoSolicituds { get; set; } = new List<DocDocumentoSolicitud>();
}
