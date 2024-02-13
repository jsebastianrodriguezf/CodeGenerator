namespace SAMMAI.DataBase.Repository.Entities;

public partial class DocMedioSolicitud : DocMedioSolicitudObject
{
    public virtual ICollection<DocDocumentoSolicitud> DocDocumentoSolicituds { get; set; } = new List<DocDocumentoSolicitud>();
}
