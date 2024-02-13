namespace SAMMAI.DataBase.Repository.Entities;

public partial class CatSistemaCatalogoEquipo : CatSistemaCatalogoEquipoObject
{
    public virtual CatCatalogoEquipo IdCatalogoEquipoNavigation { get; set; } = null!;
    public virtual CatSistema IdSistemaNavigation { get; set; } = null!;
    public virtual CatVersionEquipo IdVersionEquipoNavigation { get; set; } = null!;
}
