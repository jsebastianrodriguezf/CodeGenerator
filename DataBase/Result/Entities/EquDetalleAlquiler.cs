namespace SAMMAI.DataBase.Repository.Entities;

public partial class EquDetalleAlquiler : EquDetalleAlquilerObject
{
    public virtual ICollection<AlqDetalleLiquidacion> AlqDetalleLiquidacions { get; set; } = new List<AlqDetalleLiquidacion>();
    public virtual ICollection<AlqDetallealquilerItemdocumento> AlqDetallealquilerItemdocumentos { get; set; } = new List<AlqDetallealquilerItemdocumento>();
    public virtual ICollection<AlqTarifa> AlqTarifas { get; set; } = new List<AlqTarifa>();
    public virtual CatCatalogo IdCatalogoNavigation { get; set; } = null!;
    public virtual DocDocumentoAlquiler IdDocumentoAlquilerNavigation { get; set; } = null!;
    public virtual EquEquipo IdEquipoNavigation { get; set; } = null!;
    public virtual TerSucursal IdSucursalNavigation { get; set; } = null!;
    public virtual TerTercero IdTerceroNavigation { get; set; } = null!;
}
