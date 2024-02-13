namespace SAMMAI.DataBase.Repository.Entities;

public partial class DocSoporteItemDocumento : DocSoporteItemDocumentoObject
{
    public virtual DocItemDocumento IdItemDocumentoNavigation { get; set; } = null!;
    public virtual SegUsuario IdUsuarioNavigation { get; set; } = null!;
    public virtual ICollection<OrtProgramacion> OrtProgramacions { get; set; } = new List<OrtProgramacion>();
}
