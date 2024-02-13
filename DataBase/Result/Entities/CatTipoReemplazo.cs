namespace SAMMAI.DataBase.Repository.Entities;

public partial class CatTipoReemplazo : CatTipoReemplazoObject
{
    public virtual ICollection<CatReemplazo> CatReemplazos { get; set; } = new List<CatReemplazo>();
}
