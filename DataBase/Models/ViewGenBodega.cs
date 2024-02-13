using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewGenBodega
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string Bodega { get; set; } = null!;

    public string? BodegaCodigo { get; set; }

    public bool SalidasEnRojo { get; set; }

    public bool UsaLocalizacion { get; set; }

    public int? IdSucursal { get; set; }

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

    public string Multiempresa { get; set; } = null!;
}
