using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewTerTerceroListaprecio
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string TerceroListaprecio { get; set; } = null!;

    public int IdTercero { get; set; }

    public string TerTerceroTercero { get; set; } = null!;

    public string? TerTerceroTerceroCodigo { get; set; }

    public string TerTerceroTerceroNit { get; set; } = null!;

    public string? TerTerceroDireccion { get; set; }

    public string? TerTerceroContacto { get; set; }

    public string TerTerceroTelefono { get; set; } = null!;

    public string? TerTerceroFax { get; set; }

    public string? TerTerceroEmail { get; set; }

    public string? TerTerceroWebsite { get; set; }

    public string? TerTerceroRepresentante { get; set; }

    public string? TerTerceroNotas { get; set; }

    public string TerTerceroTerceroNombreCorto { get; set; } = null!;

    public bool TerTerceroEsCliente { get; set; }

    public bool TerTerceroEsProveedor { get; set; }

    public bool TerTerceroEsTransportador { get; set; }

    public bool TerTerceroEsFabricante { get; set; }

    public bool TerTerceroEsEmpresaPropia { get; set; }

    public string? TerTerceroClasificacion { get; set; }

    public int TerTerceroIdZona { get; set; }

    public int TerTerceroIdEstadoTercero { get; set; }

    public int TerTerceroIdNaturalezaTercero { get; set; }

    public bool TerTerceroEsProspecto { get; set; }

    public int IdListaprecio { get; set; }

    public string CatListaPrecioListaPrecio { get; set; } = null!;

    public string? CatListaPrecioListaPrecioCodigo { get; set; }

    public double CatListaPrecioPorcentajeDescuento { get; set; }

    public bool CatListaPrecioEsPrivado { get; set; }

    public int CatListaPrecioIdMoneda { get; set; }

    public string Multiempresa { get; set; } = null!;
}
