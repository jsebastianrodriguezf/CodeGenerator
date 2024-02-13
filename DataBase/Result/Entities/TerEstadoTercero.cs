namespace SAMMAI.DataBase.Repository.Entities;

public partial class TerEstadoTercero : TerEstadoTerceroObject
{
    public virtual ICollection<TerSucursal> TerSucursals { get; set; } = new List<TerSucursal>();
    public virtual ICollection<TerTercero> TerTerceros { get; set; } = new List<TerTercero>();
}
