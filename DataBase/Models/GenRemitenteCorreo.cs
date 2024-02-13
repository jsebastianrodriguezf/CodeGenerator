using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class GenRemitenteCorreo
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string RemitenteCorreo { get; set; } = null!;

    public string? RemitenteCorreoCodigo { get; set; }

    public string? Servidor { get; set; }

    public bool? Certificado { get; set; }

    public string? Puerto { get; set; }

    public string? Credenciales { get; set; }

    public bool? EsGsuite { get; set; }

    public string? CuentaCertificado { get; set; }

    public string? ArchivoCertificado { get; set; }

    public virtual ICollection<GenEnvioCorreo> GenEnvioCorreos { get; set; } = new List<GenEnvioCorreo>();
}
