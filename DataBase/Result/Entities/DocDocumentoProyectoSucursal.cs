namespace SAMMAI.DataBase.Repository.Entities;

public partial class DocDocumentoProyectoSucursal : DocDocumentoProyectoSucursalObject
{
    public virtual DocDocumentoProyecto IdDocumentoProyectoNavigation { get; set; } = null!;
    public virtual TerSucursal IdSucursalNavigation { get; set; } = null!;
}
