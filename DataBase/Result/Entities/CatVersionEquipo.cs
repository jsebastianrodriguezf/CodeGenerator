namespace SAMMAI.DataBase.Repository.Entities;

public partial class CatVersionEquipo : CatVersionEquipoObject
{
    public virtual ICollection<CatReemplazoCatalogoEquipo> CatReemplazoCatalogoEquipos { get; set; } = new List<CatReemplazoCatalogoEquipo>();
    public virtual ICollection<CatSistemaCatalogoEquipo> CatSistemaCatalogoEquipos { get; set; } = new List<CatSistemaCatalogoEquipo>();
    public virtual ICollection<CatVersionEquipoDetalleTempario> CatVersionEquipoDetalleTemparios { get; set; } = new List<CatVersionEquipoDetalleTempario>();
    public virtual ICollection<EquEquipo> EquEquipos { get; set; } = new List<EquEquipo>();
    public virtual CatCatalogoEquipo IdCatalogoEquipoNavigation { get; set; } = null!;
}
