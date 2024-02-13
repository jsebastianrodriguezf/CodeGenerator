using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewCatMarca
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string Marca { get; set; } = null!;

    public string? MarcaCodigo { get; set; }

    public int IdTerceroFabricante { get; set; }

    public string TerTerceroFabricanteTercero { get; set; } = null!;

    public string? TerTerceroFabricanteTerceroCodigo { get; set; }

    public string TerTerceroFabricanteTerceroNit { get; set; } = null!;

    public string? TerTerceroFabricanteDireccion { get; set; }

    public string? TerTerceroFabricanteContacto { get; set; }

    public string TerTerceroFabricanteTelefono { get; set; } = null!;

    public string? TerTerceroFabricanteFax { get; set; }

    public string? TerTerceroFabricanteEmail { get; set; }

    public string? TerTerceroFabricanteWebsite { get; set; }

    public string? TerTerceroFabricanteRepresentante { get; set; }

    public string? TerTerceroFabricanteNotas { get; set; }

    public string TerTerceroFabricanteTerceroNombreCorto { get; set; } = null!;

    public bool TerTerceroFabricanteEsCliente { get; set; }

    public bool TerTerceroFabricanteEsProveedor { get; set; }

    public bool TerTerceroFabricanteEsTransportador { get; set; }

    public bool TerTerceroFabricanteEsFabricante { get; set; }

    public bool TerTerceroFabricanteEsEmpresaPropia { get; set; }

    public string? TerTerceroFabricanteClasificacion { get; set; }

    public int TerTerceroFabricanteIdZona { get; set; }

    public int TerTerceroFabricanteIdEstadoTercero { get; set; }

    public int TerTerceroFabricanteIdNaturalezaTercero { get; set; }

    public bool TerTerceroFabricanteEsProspecto { get; set; }

    public string Multiempresa { get; set; } = null!;
}
