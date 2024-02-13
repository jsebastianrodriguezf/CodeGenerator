namespace SAMMAI.DataBase.Repository.Entities;

public partial class DisObraCatalogo : DisObraCatalogoObject
{
    public virtual CatCatalogo IdCatalogoNavigation { get; set; } = null!;
    public virtual DisObra IdObraNavigation { get; set; } = null!;
}
