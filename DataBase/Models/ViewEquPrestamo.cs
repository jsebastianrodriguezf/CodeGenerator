using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewEquPrestamo
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string Prestamo { get; set; } = null!;

    public string? PrestamoCodigo { get; set; }

    public DateTime? FechaPrestamoFf { get; set; }

    public DateTime? FechaCompromisoFf { get; set; }

    public string? Notas { get; set; }

    public int IdEstadoPrestamo { get; set; }

    public string EquEstadoPrestamoEstadoPrestamo { get; set; } = null!;

    public string? EquEstadoPrestamoEstadoPrestamoCodigo { get; set; }

    public int IdUsuarioEntrego { get; set; }

    public string SegUsuarioEntregoUsuario { get; set; } = null!;

    public string? SegUsuarioEntregoUsuarioCodigo { get; set; }

    public int? SegUsuarioEntregoIntentosFallidos { get; set; }

    public int? SegUsuarioEntregoNumeroIngresos { get; set; }

    public DateTime? SegUsuarioEntregoFechaUltimoIngresoFh { get; set; }

    public DateTime? SegUsuarioEntregoFechaIntentoFallidoFh { get; set; }

    public string? SegUsuarioEntregoClave { get; set; }

    public string? SegUsuarioEntregoNombre { get; set; }

    public string? SegUsuarioEntregoProfesion { get; set; }

    public string SegUsuarioEntregoEmail { get; set; } = null!;

    public string? SegUsuarioEntregoDireccion { get; set; }

    public string? SegUsuarioEntregoTelefono { get; set; }

    public decimal? SegUsuarioEntregoCostoHora { get; set; }

    public double? SegUsuarioEntregoPorcentajeComision { get; set; }

    public bool? SegUsuarioEntregoAccesoActivo { get; set; }

    public bool? SegUsuarioEntregoCambiarClave { get; set; }

    public DateTime? SegUsuarioEntregoFechaUltimoCambioClaveFh { get; set; }

    public bool SegUsuarioEntregoAplicaRecargo { get; set; }

    public bool SegUsuarioEntregoSexo { get; set; }

    public int SegUsuarioEntregoIdPerfil { get; set; }

    public int SegUsuarioEntregoIdCargo { get; set; }

    public int SegUsuarioEntregoIdGrupo { get; set; }

    public int SegUsuarioEntregoIdZona { get; set; }

    public string? SegUsuarioEntregoIdentificacion { get; set; }

    public int SegUsuarioEntregoIdUsuario { get; set; }

    public byte[]? SegUsuarioEntregoPreferencias { get; set; }

    public string Multiempresa { get; set; } = null!;
}
