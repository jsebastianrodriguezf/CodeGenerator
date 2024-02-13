using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class GenConfiguracionServicio
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string ConfiguracionServicio { get; set; } = null!;

    public string? ConfiguracionServicioCodigo { get; set; }

    public int? IdTercero { get; set; }

    public int? IdTipoServicio { get; set; }

    public int? IdCatalogo { get; set; }

    public virtual CatCatalogo? IdCatalogoNavigation { get; set; }

    public virtual TerTercero? IdTerceroNavigation { get; set; }

    public virtual GenTipoServicio? IdTipoServicioNavigation { get; set; }
}
