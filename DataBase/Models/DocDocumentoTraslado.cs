using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class DocDocumentoTraslado
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string DocumentoTraslado { get; set; } = null!;

    public int IdBodegaOrigen { get; set; }

    public int IdBodegaDestino { get; set; }

    public virtual GenBodega IdBodegaDestinoNavigation { get; set; } = null!;

    public virtual GenBodega IdBodegaOrigenNavigation { get; set; } = null!;
}
