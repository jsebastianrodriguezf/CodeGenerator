namespace SAMMAI.DataBase.Repository.Entities;

public partial class DocDocumentoCotizacion : DocDocumentoCotizacionObject
{
    public virtual ICollection<DocDocumentoCotizacionCondicion> DocDocumentoCotizacionCondicions { get; set; } = new List<DocDocumentoCotizacionCondicion>();
    public virtual EquEquipo IdEquipoNavigation { get; set; } = null!;
    public virtual TerSucursal IdSucursalNavigation { get; set; } = null!;
    public virtual SegUsuario IdUsuarioAsesorNavigation { get; set; } = null!;
}
