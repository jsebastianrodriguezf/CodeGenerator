using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class SegRegistroIntegracion
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string RegistroIntegracion { get; set; } = null!;

    public string? RegistroIntegracionCodigo { get; set; }

    public string? Mensaje { get; set; }

    public string? Respuesta { get; set; }

    public string? CodigoRespuesta { get; set; }

    public int? IdObjeto { get; set; }

    public int IdPuntoIntegracion { get; set; }

    public int? NumeroReintento { get; set; }

    public virtual SynPuntoIntegracion IdPuntoIntegracionNavigation { get; set; } = null!;
}
