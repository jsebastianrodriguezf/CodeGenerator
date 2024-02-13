using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewSegRegistroPeticion
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string RegistroPeticion { get; set; } = null!;

    public string? RegistroPeticionCodigo { get; set; }

    public string UrlServicio { get; set; } = null!;

    public string Modulo { get; set; } = null!;

    public string Aplicacion { get; set; } = null!;

    public bool EsExitosa { get; set; }

    public string MensajeRespuesta { get; set; } = null!;

    public int IdUsuario { get; set; }

    public string SegUsuarioUsuario { get; set; } = null!;

    public string? SegUsuarioUsuarioCodigo { get; set; }

    public int? SegUsuarioIntentosFallidos { get; set; }

    public int? SegUsuarioNumeroIngresos { get; set; }

    public DateTime? SegUsuarioFechaUltimoIngresoFh { get; set; }

    public DateTime? SegUsuarioFechaIntentoFallidoFh { get; set; }

    public string? SegUsuarioClave { get; set; }

    public string? SegUsuarioNombre { get; set; }

    public string? SegUsuarioProfesion { get; set; }

    public string SegUsuarioEmail { get; set; } = null!;

    public string? SegUsuarioDireccion { get; set; }

    public string? SegUsuarioTelefono { get; set; }

    public decimal? SegUsuarioCostoHora { get; set; }

    public double? SegUsuarioPorcentajeComision { get; set; }

    public bool? SegUsuarioAccesoActivo { get; set; }

    public bool? SegUsuarioCambiarClave { get; set; }

    public DateTime? SegUsuarioFechaUltimoCambioClaveFh { get; set; }

    public bool SegUsuarioAplicaRecargo { get; set; }

    public bool SegUsuarioSexo { get; set; }

    public int SegUsuarioIdPerfil { get; set; }

    public int SegUsuarioIdCargo { get; set; }

    public int SegUsuarioIdGrupo { get; set; }

    public int SegUsuarioIdZona { get; set; }

    public string? SegUsuarioIdentificacion { get; set; }

    public int SegUsuarioIdUsuario { get; set; }

    public byte[]? SegUsuarioPreferencias { get; set; }

    public bool SegUsuarioHabilitado { get; set; }

    public string? SegUsuarioIdDispositivo { get; set; }

    public double? TamanoPeticion { get; set; }

    public string Multiempresa { get; set; } = null!;
}
