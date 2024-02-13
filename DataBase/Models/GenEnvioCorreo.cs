using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class GenEnvioCorreo
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string EnvioCorreo { get; set; } = null!;

    public string? EnvioCorreoCodigo { get; set; }

    public int Estrategia { get; set; }

    public string Tabla { get; set; } = null!;

    public int IdReporte { get; set; }

    public string? CorreoAdicional { get; set; }

    public string? PlantillaAdjunto { get; set; }

    public int IdSubtipoDocumento { get; set; }

    public int IdEstadoTipoDocumento { get; set; }

    public int CantidadMensajes { get; set; }

    public int TiempoPorMensajes { get; set; }

    public int CantidadReintento { get; set; }

    public int? AdjuntarArchivo { get; set; }

    public int? IdRemitenteCorreo { get; set; }

    public virtual ICollection<GenRegistroEnvio> GenRegistroEnvios { get; set; } = new List<GenRegistroEnvio>();

    public virtual DocEstadoTipoDocumento IdEstadoTipoDocumentoNavigation { get; set; } = null!;

    public virtual GenRemitenteCorreo? IdRemitenteCorreoNavigation { get; set; }

    public virtual RepReporte IdReporteNavigation { get; set; } = null!;

    public virtual DocSubtipoDocumento IdSubtipoDocumentoNavigation { get; set; } = null!;

    public virtual ICollection<SegCargoEnvioCorreo> SegCargoEnvioCorreos { get; set; } = new List<SegCargoEnvioCorreo>();
}
