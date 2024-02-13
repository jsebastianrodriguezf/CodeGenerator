namespace SAMMAI.DataBase.Repository.Entities;

public partial class EquTrazabilidad : EquTrazabilidadObject
{
    public virtual EquCicloHorometro IdCicloHorometroNavigation { get; set; } = null!;
    public virtual DocDocumentoAlquiler IdDocumentoAlquilerNavigation { get; set; } = null!;
    public virtual DocDocumento IdDocumentoNavigation { get; set; } = null!;
    public virtual EquEquipo IdEquipoNavigation { get; set; } = null!;
    public virtual EquEquipo IdEquipoPadreNavigation { get; set; } = null!;
    public virtual DisEvento IdEventoNavigation { get; set; } = null!;
    public virtual CatPosicion IdPosicionNavigation { get; set; } = null!;
    public virtual EquPrestamo IdPrestamoNavigation { get; set; } = null!;
    public virtual OrtReporteTecnico IdReporteTecnicoNavigation { get; set; } = null!;
    public virtual TerSucursal IdSucursalNavigation { get; set; } = null!;
    public virtual TerTercero IdTerceroNavigation { get; set; } = null!;
    public virtual EquTipoTrazabilidad IdTipoTrazabilidadNavigation { get; set; } = null!;
}
