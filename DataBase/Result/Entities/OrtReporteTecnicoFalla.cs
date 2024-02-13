namespace SAMMAI.DataBase.Repository.Entities;

public partial class OrtReporteTecnicoFalla : OrtReporteTecnicoFallaObject
{
    public virtual EquFalla IdFallaCausaNavigation { get; set; } = null!;
    public virtual EquFalla IdFallaEfectoNavigation { get; set; } = null!;
    public virtual EquFalla IdFallaNavigation { get; set; } = null!;
    public virtual OrtReporteTecnico IdReporteTecnicoNavigation { get; set; } = null!;
}
