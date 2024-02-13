namespace SAMMAI.DataBase.Repository.Entities;

public partial class DocDocumentoComentario : DocDocumentoComentarioObject
{
    public virtual TerContacto IdContactoNavigation { get; set; } = null!;
    public virtual DocDocumentoComentario IdDocumentoComentarioNavigation { get; set; } = null!;
    public virtual DocDocumento IdDocumentoNavigation { get; set; } = null!;
    public virtual OrtReporteTecnico IdReporteTecnicoNavigation { get; set; } = null!;
    public virtual SegUsuario IdUsuarioNavigation { get; set; } = null!;
    public virtual ICollection<DocDocumentoComentario> InverseIdDocumentoComentarioNavigation { get; set; } = new List<DocDocumentoComentario>();
}
