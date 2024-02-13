namespace SAMMAI.DataBase.Repository.Entities;

public partial class DocDocumentoOrdenCompra : DocDocumentoOrdenCompraObject
{
    public virtual DocFormaPago IdFormaPagoNavigation { get; set; } = null!;
    public virtual TerSucursal IdSucursalNavigation { get; set; } = null!;
}
