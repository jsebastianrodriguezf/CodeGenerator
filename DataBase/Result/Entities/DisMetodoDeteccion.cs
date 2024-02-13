namespace SAMMAI.DataBase.Repository.Entities;

public partial class DisMetodoDeteccion : DisMetodoDeteccionObject
{
    public virtual ICollection<DisEvento> DisEventos { get; set; } = new List<DisEvento>();
}
