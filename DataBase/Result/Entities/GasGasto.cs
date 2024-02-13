namespace SAMMAI.DataBase.Repository.Entities;

public partial class GasGasto : GasGastoObject
{
    public virtual ICollection<GasDetalleGasto> GasDetalleGastos { get; set; } = new List<GasDetalleGasto>();
    public virtual DocEstadoTipoDocumento IdEstadoTipoDocumentoNavigation { get; set; } = null!;
    public virtual GasTipoGasto IdTipoGastoNavigation { get; set; } = null!;
    public virtual SegUsuario IdUsuarioAproboNavigation { get; set; } = null!;
    public virtual SegUsuario IdUsuarioSolicitanteNavigation { get; set; } = null!;
    public virtual ICollection<OrtReporteTecnico> OrtReporteTecnicos { get; set; } = new List<OrtReporteTecnico>();
}
