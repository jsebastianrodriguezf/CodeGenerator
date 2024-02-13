namespace SAMMAI.DataBase.Repository.Entities;

public partial class DocFormaPago : DocFormaPagoObject
{
    public virtual ICollection<DocDocumentoOrdenCompra> DocDocumentoOrdenCompras { get; set; } = new List<DocDocumentoOrdenCompra>();
    public virtual ICollection<TerTercero> TerTerceros { get; set; } = new List<TerTercero>();
}
