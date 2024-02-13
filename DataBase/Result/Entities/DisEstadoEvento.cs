namespace SAMMAI.DataBase.Repository.Entities;

public partial class DisEstadoEvento : DisEstadoEventoObject
{
    public virtual ICollection<DisEventoEstadoEvento> DisEventoEstadoEventos { get; set; } = new List<DisEventoEstadoEvento>();
    public virtual ICollection<DisEvento> DisEventos { get; set; } = new List<DisEvento>();
}
