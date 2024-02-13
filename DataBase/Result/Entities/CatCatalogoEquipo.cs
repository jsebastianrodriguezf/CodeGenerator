namespace SAMMAI.DataBase.Repository.Entities;

public partial class CatCatalogoEquipo : CatCatalogoEquipoObject
{
    public virtual ICollection<CatCatalogoEquipoCatalogoTempario> CatCatalogoEquipoCatalogoTemparios { get; set; } = new List<CatCatalogoEquipoCatalogoTempario>();
    public virtual ICollection<CatCatalogoEquipoPruebaCheckList> CatCatalogoEquipoPruebaCheckLists { get; set; } = new List<CatCatalogoEquipoPruebaCheckList>();
    public virtual ICollection<CatPosicion> CatPosicionIdCatalogoEquipoComponenteNavigations { get; set; } = new List<CatPosicion>();
    public virtual ICollection<CatPosicion> CatPosicionIdCatalogoEquipoEquipoNavigations { get; set; } = new List<CatPosicion>();
    public virtual ICollection<CatReemplazoCatalogoEquipo> CatReemplazoCatalogoEquipos { get; set; } = new List<CatReemplazoCatalogoEquipo>();
    public virtual ICollection<CatSistemaCatalogoEquipo> CatSistemaCatalogoEquipos { get; set; } = new List<CatSistemaCatalogoEquipo>();
    public virtual ICollection<CatTarifa> CatTarifas { get; set; } = new List<CatTarifa>();
    public virtual ICollection<CatVersionEquipo> CatVersionEquipos { get; set; } = new List<CatVersionEquipo>();
    public virtual ICollection<EquAnalisisFalla> EquAnalisisFallas { get; set; } = new List<EquAnalisisFalla>();
    public virtual ICollection<EquEquipo> EquEquipos { get; set; } = new List<EquEquipo>();
    public virtual CatMarca IdMarcaNavigation { get; set; } = null!;
    public virtual ICollection<SegUsuarioCatalogoEquipo> SegUsuarioCatalogoEquipos { get; set; } = new List<SegUsuarioCatalogoEquipo>();
}
