namespace SAMMAI.DataBase.Repository.Entities;

public partial class AlqDetallealquilerItemdocumento : AlqDetallealquilerItemdocumentoObject
{
    public virtual EquDetalleAlquiler IdDetallealquilerNavigation { get; set; } = null!;
    public virtual DocItemDocumento IdItemdocumentoNavigation { get; set; } = null!;
}
