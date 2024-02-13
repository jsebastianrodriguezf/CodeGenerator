namespace SAMMAI.DataBase.Repository.Entities;

public partial class DisEventoEstadoEvento : DisEventoEstadoEventoObject
{
    public virtual DisEstadoEvento IdEstadoEventoNavigation { get; set; } = null!;
    public virtual DisEvento IdEventoNavigation { get; set; } = null!;
    public virtual CatSistema IdSistemaNavigation { get; set; } = null!;
}
