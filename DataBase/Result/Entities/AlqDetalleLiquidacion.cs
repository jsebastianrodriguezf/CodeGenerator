namespace SAMMAI.DataBase.Repository.Entities;

public partial class AlqDetalleLiquidacion : AlqDetalleLiquidacionObject
{
    public virtual EquDetalleAlquiler? IdDetalleAlquilerNavigation { get; set; }
    public virtual DisEvento IdEventoNavigation { get; set; } = null!;
    public virtual DocItemDocumento? IdItemDocumentoNavigation { get; set; }
    public virtual AlqTarifa? IdTarifaNavigation { get; set; }
}
