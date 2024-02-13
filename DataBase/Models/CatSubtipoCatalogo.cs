using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class CatSubtipoCatalogo
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string SubtipoCatalogo { get; set; } = null!;

    public string? SubtipoCatalogoCodigo { get; set; }

    public int IdTipoCatalogo { get; set; }

    public virtual ICollection<CatCatalogo> CatCatalogos { get; set; } = new List<CatCatalogo>();

    public virtual ICollection<ComComision> ComComisions { get; set; } = new List<ComComision>();

    public virtual CatTipoCatalogo IdTipoCatalogoNavigation { get; set; } = null!;
}
