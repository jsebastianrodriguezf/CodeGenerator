namespace SAMMAI.DataBase.Repository.Entities;

public partial class GasDocumentoOtDetalleGasto : GasDocumentoOtDetalleGastoObject
{
    public virtual GasDetalleGasto IdDetalleGastoNavigation { get; set; } = null!;
    public virtual DocDocumentoOt IdDocumentoOtNavigation { get; set; } = null!;
    public virtual DocItemDocumento IdItemDocumentoNavigation { get; set; } = null!;
}
