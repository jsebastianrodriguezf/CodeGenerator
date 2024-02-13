namespace SAMMAI.DataBase.Repository.Entities;

public partial class RepOrigenDato : RepOrigenDatoObject
{
    public virtual RepReporte IdReporteNavigation { get; set; } = null!;
}
