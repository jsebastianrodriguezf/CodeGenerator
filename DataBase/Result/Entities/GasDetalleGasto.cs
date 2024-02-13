namespace SAMMAI.DataBase.Repository.Entities;

public partial class GasDetalleGasto : GasDetalleGastoObject
{
    public virtual ICollection<GasDocumentoOtDetalleGasto> GasDocumentoOtDetalleGastos { get; set; } = new List<GasDocumentoOtDetalleGasto>();
    public virtual CatCatalogo IdCatalogoNavigation { get; set; } = null!;
    public virtual GasGasto IdGastoNavigation { get; set; } = null!;
}
