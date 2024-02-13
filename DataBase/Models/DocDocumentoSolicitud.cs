using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class DocDocumentoSolicitud
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string DocumentoSolicitud { get; set; } = null!;

    public string? Email { get; set; }

    public string? Fax { get; set; }

    public string Telefono { get; set; } = null!;

    public string Solicitante { get; set; } = null!;

    public string? MotivoServicio { get; set; }

    public bool SolucionTelefonica { get; set; }

    public int IdDepartamentoSolicitud { get; set; }

    public int IdMedioSolicitud { get; set; }

    public int IdEquipo { get; set; }

    public int IdSucursal { get; set; }

    public int IdZona { get; set; }

    public string? Cargo { get; set; }

    public string? Direccion { get; set; }

    public virtual OrtDepartamentoSolicitud IdDepartamentoSolicitudNavigation { get; set; } = null!;

    public virtual EquEquipo IdEquipoNavigation { get; set; } = null!;

    public virtual DocMedioSolicitud IdMedioSolicitudNavigation { get; set; } = null!;

    public virtual TerSucursal IdSucursalNavigation { get; set; } = null!;

    public virtual GenZona IdZonaNavigation { get; set; } = null!;
}
