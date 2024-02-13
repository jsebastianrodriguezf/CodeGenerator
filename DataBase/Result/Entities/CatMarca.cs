namespace SAMMAI.DataBase.Repository.Entities;

public partial class CatMarca : CatMarcaObject
{
    public virtual ICollection<CatCatalogoEquipo> CatCatalogoEquipos { get; set; } = new List<CatCatalogoEquipo>();
    public virtual ICollection<CatCatalogoRepuesto> CatCatalogoRepuestos { get; set; } = new List<CatCatalogoRepuesto>();
    public virtual ICollection<CatTarifa> CatTarifas { get; set; } = new List<CatTarifa>();
    public virtual TerTercero IdTerceroFabricanteNavigation { get; set; } = null!;
}
