using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewTerContactoSucursal
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string ContactoSucursal { get; set; } = null!;

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

    public string Multiempresa { get; set; } = null!;
}
