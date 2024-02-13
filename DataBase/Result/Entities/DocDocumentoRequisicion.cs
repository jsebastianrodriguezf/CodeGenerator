namespace SAMMAI.DataBase.Repository.Entities;

public partial class DocDocumentoRequisicion : DocDocumentoRequisicionObject
{
    public virtual TerSucursal IdSucursalNavigation { get; set; } = null!;
}
