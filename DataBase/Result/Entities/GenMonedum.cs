namespace SAMMAI.DataBase.Repository.Entities;

public partial class GenMonedum : GenMonedumObject
{
    public virtual ICollection<CatListaPrecio> CatListaPrecios { get; set; } = new List<CatListaPrecio>();
    public virtual ICollection<DocDocumento> DocDocumentos { get; set; } = new List<DocDocumento>();
}
