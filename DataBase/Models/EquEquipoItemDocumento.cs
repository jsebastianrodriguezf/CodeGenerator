using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class EquEquipoItemDocumento
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string EquipoItemDocumento { get; set; } = null!;

    public int IdEquipo { get; set; }

    public int IdItemDocumento { get; set; }

    public int IdCatalogo { get; set; }

    public virtual CatCatalogo IdCatalogoNavigation { get; set; } = null!;

    public virtual EquEquipo IdEquipoNavigation { get; set; } = null!;

    public virtual DocItemDocumento IdItemDocumentoNavigation { get; set; } = null!;
}
