namespace SAMMAI.DataBase.Repository.Entities;

public partial class CatPosicion : CatPosicionObject
{
    public virtual ICollection<EquTrazabilidad> EquTrazabilidads { get; set; } = new List<EquTrazabilidad>();
    public virtual CatCatalogoEquipo IdCatalogoEquipoComponenteNavigation { get; set; } = null!;
    public virtual CatCatalogoEquipo IdCatalogoEquipoEquipoNavigation { get; set; } = null!;
    public virtual CatDimension IdDimensionXNavigation { get; set; } = null!;
    public virtual CatDimension IdDimensionYNavigation { get; set; } = null!;
    public virtual CatDimension IdDimensionZNavigation { get; set; } = null!;
}
