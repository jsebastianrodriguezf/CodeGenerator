using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewDocSoporteItemDocumento
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string SoporteItemDocumento { get; set; } = null!;

    public string? SoporteItemDocumentoCodigo { get; set; }

    public double DuracionPlaneada { get; set; }

    public decimal Valor { get; set; }

    public decimal Costo { get; set; }

    public int IdItemDocumento { get; set; }

    public string DocItemDocumentoItemDocumento { get; set; } = null!;

    public string? DocItemDocumentoItemDocumentoCodigo { get; set; }

    public string DocItemDocumentoDetalle { get; set; } = null!;

    public double DocItemDocumentoHorasOrdinales { get; set; }

    public double DocItemDocumentoHorasFestivas { get; set; }

    public double DocItemDocumentoHorasNocturnas { get; set; }

    public double DocItemDocumentoCantidadPlaneado { get; set; }

    public double DocItemDocumentoCantidadEjecutado { get; set; }

    public decimal DocItemDocumentoValorUnitarioPlaneado { get; set; }

    public decimal DocItemDocumentoValorUnitarioEjecutado { get; set; }

    public decimal DocItemDocumentoSubtotalPlaneado { get; set; }

    public decimal DocItemDocumentoSubtotalEjecutado { get; set; }

    public decimal DocItemDocumentoTotalPlaneado { get; set; }

    public decimal DocItemDocumentoTotalEjecutado { get; set; }

    public double DocItemDocumentoPorciva { get; set; }

    public decimal DocItemDocumentoIvaPlaneado { get; set; }

    public decimal DocItemDocumentoIvaEjecutado { get; set; }

    public double DocItemDocumentoPorcdto { get; set; }

    public decimal DocItemDocumentoDtoPlaneado { get; set; }

    public decimal DocItemDocumentoDtoEjecutado { get; set; }

    public bool DocItemDocumentoCostear { get; set; }

    public bool DocItemDocumentoEsUrgente { get; set; }

    public DateTime? DocItemDocumentoVencimientoGarantiaFf { get; set; }

    public double? DocItemDocumentoHorasGarantia { get; set; }

    public double? DocItemDocumentoPorcentajeCliente { get; set; }

    public double? DocItemDocumentoPorcentajeDistribuidor { get; set; }

    public double? DocItemDocumentoPorcentajeFabricante { get; set; }

    public bool DocItemDocumentoAfectoInventario { get; set; }

    public int DocItemDocumentoIdDocumento { get; set; }

    public int DocItemDocumentoIdItemDocumento { get; set; }

    public int DocItemDocumentoIdCentroCosto { get; set; }

    public int DocItemDocumentoIdCatalogo { get; set; }

    public int DocItemDocumentoIdBodega { get; set; }

    public int DocItemDocumentoIdIncoterm { get; set; }

    public int DocItemDocumentoIdItemDocumentoSuperior { get; set; }

    public double DocItemDocumentoCostoPlaneado { get; set; }

    public double DocItemDocumentoCostoEjecutado { get; set; }

    public int DocItemDocumentoIdListaprecio { get; set; }

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

    public double DuracionEjecutada { get; set; }

    public double HorasOrdinales { get; set; }

    public double HorasFestivas { get; set; }

    public double HorasNocturnas { get; set; }

    public string Periodo { get; set; } = null!;

    public string Multiempresa { get; set; } = null!;
}
