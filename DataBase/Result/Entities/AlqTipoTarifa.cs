namespace SAMMAI.DataBase.Repository.Entities;

public partial class AlqTipoTarifa : AlqTipoTarifaObject
{
    public virtual ICollection<AlqTarifa> AlqTarifas { get; set; } = new List<AlqTarifa>();
}
