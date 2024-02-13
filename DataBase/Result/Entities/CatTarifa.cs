namespace SAMMAI.DataBase.Repository.Entities;

public partial class CatTarifa : CatTarifaObject
{
    public virtual ICollection<CatTarifaRango> CatTarifaRangos { get; set; } = new List<CatTarifaRango>();
    public virtual CatAtributo IdAtributoNavigation { get; set; } = null!;
    public virtual SegCargo IdCargoNavigation { get; set; } = null!;
    public virtual CatCatalogoEquipo IdCatalogoEquipoNavigation { get; set; } = null!;
    public virtual GenFamilium IdFamiliaNavigation { get; set; } = null!;
    public virtual CatMarca IdMarcaNavigation { get; set; } = null!;
    public virtual GenTipoServicio IdTipoServicioNavigation { get; set; } = null!;
    public virtual GenZona IdZonaNavigation { get; set; } = null!;
}
