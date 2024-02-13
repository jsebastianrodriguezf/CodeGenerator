namespace SAMMAI.DataBase.Repository.Entities;

public partial class OrtProgramacion : OrtProgramacionObject
{
    public virtual CatCatalogoActividad IdCatalogoActividadNavigation { get; set; } = null!;
    public virtual DocDocumentoOt IdDocumentoOtNavigation { get; set; } = null!;
    public virtual OrtMotivoCancelacion IdMotivoCancelacionNavigation { get; set; } = null!;
    public virtual OrtProgramacion IdProgramacionNavigation { get; set; } = null!;
    public virtual OrtReporteTecnico IdReporteTecnicoNavigation { get; set; } = null!;
    public virtual DocSoporteItemDocumento IdSoporteItemDocumentoNavigation { get; set; } = null!;
    public virtual OrtTipoProgramacion IdTipoProgramacionNavigation { get; set; } = null!;
    public virtual SegUsuario IdUsuarioNavigation { get; set; } = null!;
    public virtual ICollection<OrtProgramacion> InverseIdProgramacionNavigation { get; set; } = new List<OrtProgramacion>();
}
