using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class GenRegistroEnvio
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string RegistroEnvio { get; set; } = null!;

    public string? RegistroEnvioCodigo { get; set; }

    public string Tabla { get; set; } = null!;

    public bool Reintentar { get; set; }

    public int IdEnvioCorreo { get; set; }

    public int IdRegistroEnvio { get; set; }

    public virtual ICollection<GenDetalleRegistroEnvio> GenDetalleRegistroEnvios { get; set; } = new List<GenDetalleRegistroEnvio>();

    public virtual GenEnvioCorreo IdEnvioCorreoNavigation { get; set; } = null!;

    public virtual GenRegistroEnvio IdRegistroEnvioNavigation { get; set; } = null!;

    public virtual ICollection<GenRegistroEnvio> InverseIdRegistroEnvioNavigation { get; set; } = new List<GenRegistroEnvio>();
}
