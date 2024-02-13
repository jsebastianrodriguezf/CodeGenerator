namespace SAMMAI.DataBase.Repository.Entities;

public partial class DocDocumentoEntradum : DocDocumentoEntradumObject
{
    public virtual TerSucursal IdSucursalNavigation { get; set; } = null!;
    public virtual TerTercero IdTerceroTransportadorNavigation { get; set; } = null!;
    public virtual SegUsuario IdUsuarioRecibeNavigation { get; set; } = null!;
}
