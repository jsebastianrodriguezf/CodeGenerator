namespace SAMMAI.DataBase.Repository.Entities;

public partial class AlqTarifa : AlqTarifaObject
{
    public virtual ICollection<AlqDetalleLiquidacion> AlqDetalleLiquidacions { get; set; } = new List<AlqDetalleLiquidacion>();
    public virtual EquDetalleAlquiler IdDetalleAlquilerNavigation { get; set; } = null!;
    public virtual DocItemDocumento IdItemDocumentoNavigation { get; set; } = null!;
    public virtual AlqTipoTarifa IdTipoTarifaNavigation { get; set; } = null!;
}
