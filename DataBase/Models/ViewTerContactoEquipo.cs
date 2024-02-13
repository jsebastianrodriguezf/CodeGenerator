using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewTerContactoEquipo
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string ContactoEquipo { get; set; } = null!;

    public int IdEquipo { get; set; }

    public string EquEquipoEquipo { get; set; } = null!;

    public string? EquEquipoEquipoCodigo { get; set; }

    public string EquEquipoEquipoSerial { get; set; } = null!;

    public string? EquEquipoNombreContacto { get; set; }

    public string? EquEquipoTelefonoContacto { get; set; }

    public string? EquEquipoUbicacion { get; set; }

    public string? EquEquipoObservaciones { get; set; }

    public DateTime? EquEquipoFechaPuestaMarchaFh { get; set; }

    public DateTime? EquEquipoVencimientoGarantiaFabricaFf { get; set; }

    public DateTime? EquEquipoVencimientoGarantiaDistribuidorFf { get; set; }

    public double? EquEquipoHorasGarantia { get; set; }

    public DateTime? EquEquipoUltimaLecturaFh { get; set; }

    public double EquEquipoHorometroActual { get; set; }

    public double EquEquipoPromedioHoras { get; set; }

    public decimal? EquEquipoCosto { get; set; }

    public DateTime? EquEquipoFechaImportacionFf { get; set; }

    public string? EquEquipoGarantiaCancelada { get; set; }

    public int EquEquipoIdCatalogoEquipo { get; set; }

    public int EquEquipoIdSistema { get; set; }

    public int EquEquipoIdSucursal { get; set; }

    public int EquEquipoIdZona { get; set; }

    public int EquEquipoIdVersionEquipo { get; set; }

    public int EquEquipoIdTerceroComprador { get; set; }

    public int EquEquipoIdTercero { get; set; }

    public int EquEquipoIdTerceroServicio { get; set; }

    public int EquEquipoIdEquipo { get; set; }

    public int EquEquipoIdEstadoEquipo { get; set; }

    public int EquEquipoIdCentroCosto { get; set; }

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

    public int IdContacto { get; set; }

    public string TerContactoContacto { get; set; } = null!;

    public string? TerContactoContactoCodigo { get; set; }

    public string TerContactoTelefono { get; set; } = null!;

    public string? TerContactoFax { get; set; }

    public string? TerContactoEmail { get; set; }

    public string? TerContactoDireccion { get; set; }

    public string? TerContactoTelefonoMovil { get; set; }

    public int TerContactoIdTercero { get; set; }

    public int TerContactoIdUsuario { get; set; }

    public string? TerContactoCargo { get; set; }

    public string? TerContactoCodigoAcceso { get; set; }

    public int? TerContactoIdCargoContacto { get; set; }

    public bool TerContactoAccesoActivo { get; set; }

    public int? TerContactoTerCargoContactoIdUsuarioModifico { get; set; }

    public int? TerContactoTerCargoContactoIdUsuarioCreo { get; set; }

    public string Multiempresa { get; set; } = null!;
}
