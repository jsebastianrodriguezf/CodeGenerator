using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class AlqDetallealquilerItemdocumento
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string DetallealquilerItemdocumento { get; set; } = null!;

    public int IdDetallealquiler { get; set; }

    public int IdItemdocumento { get; set; }

    public virtual EquDetalleAlquiler IdDetallealquilerNavigation { get; set; } = null!;

    public virtual DocItemDocumento IdItemdocumentoNavigation { get; set; } = null!;
}
