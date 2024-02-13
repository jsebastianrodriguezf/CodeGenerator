namespace SAMMAI.DataBase.Repository.Entities;

public partial class RepIndicador : RepIndicadorObject
{
    public virtual RepReporte IdReporteNavigation { get; set; } = null!;
}
