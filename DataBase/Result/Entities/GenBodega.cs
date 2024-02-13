namespace SAMMAI.DataBase.Repository.Entities;

public partial class GenBodega : GenBodegaObject
{
    public virtual ICollection<CatCatalogoBodega> CatCatalogoBodegas { get; set; } = new List<CatCatalogoBodega>();
    public virtual ICollection<DocDocumentoTraslado> DocDocumentoTrasladoIdBodegaDestinoNavigations { get; set; } = new List<DocDocumentoTraslado>();
    public virtual ICollection<DocDocumentoTraslado> DocDocumentoTrasladoIdBodegaOrigenNavigations { get; set; } = new List<DocDocumentoTraslado>();
    public virtual ICollection<DocItemDocumento> DocItemDocumentos { get; set; } = new List<DocItemDocumento>();
    public virtual ICollection<GenBodegaUsuario> GenBodegaUsuarios { get; set; } = new List<GenBodegaUsuario>();
    public virtual TerSucursal? IdSucursalNavigation { get; set; }
}
