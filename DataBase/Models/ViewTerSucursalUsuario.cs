using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewTerSucursalUsuario
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string SucursalUsuario { get; set; } = null!;

    public int IdSucursal { get; set; }

    public string TerSucursalSucursal { get; set; } = null!;

    public string? TerSucursalSucursalCodigo { get; set; }

    public string? TerSucursalContacto { get; set; }

    public string TerSucursalTelefono { get; set; } = null!;

    public string? TerSucursalFax { get; set; }

    public string? TerSucursalEmail { get; set; }

    public string? TerSucursalDireccion { get; set; }

    public bool TerSucursalParaVenta { get; set; }

    public bool TerSucursalParaSoporte { get; set; }

    public bool TerSucursalParaAlquiler { get; set; }

    public int TerSucursalIdTercero { get; set; }

    public int TerSucursalIdZona { get; set; }

    public int TerSucursalIdUsuarioAsesor { get; set; }

    public int TerSucursalIdUsuarioTecnico { get; set; }

    public int TerSucursalIdSucursal { get; set; }

    public int TerSucursalIdEstadoTercero { get; set; }

    public string? TerSucursalCodigorecursiva { get; set; }

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

    public string Multiempresa { get; set; } = null!;
}
