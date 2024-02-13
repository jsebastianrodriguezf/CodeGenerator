namespace SAMMAI.DataBase.Repository.Entities;

public partial class DisObra : DisObraObject
{
    public virtual ICollection<DisObraCatalogo> DisObraCatalogos { get; set; } = new List<DisObraCatalogo>();
    public virtual ICollection<DisObraEquipo> DisObraEquipos { get; set; } = new List<DisObraEquipo>();
    public virtual TerSucursal IdSucursalNavigation { get; set; } = null!;
}
