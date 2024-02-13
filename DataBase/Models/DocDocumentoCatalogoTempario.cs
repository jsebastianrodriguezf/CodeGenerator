using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class DocDocumentoCatalogoTempario
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string DocumentoCatalogoTempario { get; set; } = null!;

    public int IdCatalogoTempario { get; set; }

    public int IdDocumento { get; set; }

    public int IdItemDocumento { get; set; }

    public virtual CatCatalogoTempario IdCatalogoTemparioNavigation { get; set; } = null!;

    public virtual DocDocumento IdDocumentoNavigation { get; set; } = null!;

    public virtual DocItemDocumento IdItemDocumentoNavigation { get; set; } = null!;
}
