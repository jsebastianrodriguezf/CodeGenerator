namespace SAMMAI.DataBase.Repository.Entities;

public partial class DisMotivoEvento : DisMotivoEventoObject
{
    public virtual ICollection<DisEvento> DisEventos { get; set; } = new List<DisEvento>();
}
