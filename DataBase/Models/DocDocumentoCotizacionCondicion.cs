using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class DocDocumentoCotizacionCondicion
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string DocumentoCotizacionCondicion { get; set; } = null!;

    public bool? Imprimir { get; set; }

    public int IdOpcionCondicion { get; set; }

    public int IdDocumentoCotizacion { get; set; }

    public int IdCondicion { get; set; }

    public virtual DocCondicion IdCondicionNavigation { get; set; } = null!;

    public virtual DocDocumentoCotizacion IdDocumentoCotizacionNavigation { get; set; } = null!;

    public virtual DocOpcionCondicion IdOpcionCondicionNavigation { get; set; } = null!;
}
