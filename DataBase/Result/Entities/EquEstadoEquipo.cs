namespace SAMMAI.DataBase.Repository.Entities;

public partial class EquEstadoEquipo : EquEstadoEquipoObject
{
    public virtual ICollection<AlqHistoricoAlquiler> AlqHistoricoAlquilers { get; set; } = new List<AlqHistoricoAlquiler>();
    public virtual ICollection<DisEvento> DisEventos { get; set; } = new List<DisEvento>();
    public virtual ICollection<EquEquipo> EquEquipos { get; set; } = new List<EquEquipo>();
}
