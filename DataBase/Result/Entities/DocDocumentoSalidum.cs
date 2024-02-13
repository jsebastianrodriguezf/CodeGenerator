namespace SAMMAI.DataBase.Repository.Entities;

public partial class DocDocumentoSalidum : DocDocumentoSalidumObject
{
    public virtual TerSucursal IdSucursalNavigation { get; set; } = null!;
    public virtual TerTercero IdTerceroTransportadorNavigation { get; set; } = null!;
    public virtual SegUsuario IdUsuarioRecibeNavigation { get; set; } = null!;
}
