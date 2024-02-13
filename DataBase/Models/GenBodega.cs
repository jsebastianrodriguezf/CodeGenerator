using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class GenBodega
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string Bodega { get; set; } = null!;

    public string? BodegaCodigo { get; set; }

    public bool SalidasEnRojo { get; set; }

    public bool UsaLocalizacion { get; set; }

    public int? IdSucursal { get; set; }

    public virtual ICollection<CatCatalogoBodega> CatCatalogoBodegas { get; set; } = new List<CatCatalogoBodega>();

    public virtual ICollection<DocDocumentoTraslado> DocDocumentoTrasladoIdBodegaDestinoNavigations { get; set; } = new List<DocDocumentoTraslado>();

    public virtual ICollection<DocDocumentoTraslado> DocDocumentoTrasladoIdBodegaOrigenNavigations { get; set; } = new List<DocDocumentoTraslado>();

    public virtual ICollection<DocItemDocumento> DocItemDocumentos { get; set; } = new List<DocItemDocumento>();

    public virtual ICollection<GenBodegaUsuario> GenBodegaUsuarios { get; set; } = new List<GenBodegaUsuario>();

    public virtual TerSucursal? IdSucursalNavigation { get; set; }
}
