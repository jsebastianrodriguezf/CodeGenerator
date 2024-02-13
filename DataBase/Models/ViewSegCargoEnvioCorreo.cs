using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewSegCargoEnvioCorreo
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string CargoEnvioCorreo { get; set; } = null!;

    public int IdCargo { get; set; }

    public string SegCargoCargo { get; set; } = null!;

    public string? SegCargoCargoCodigo { get; set; }

    public bool? SegCargoEsTecnico { get; set; }

    public bool? SegCargoEsComercial { get; set; }

    public bool? SegCargoEsCoordinador { get; set; }

    public decimal? SegCargoValorHora { get; set; }

    public bool SegCargoEsAdministrativo { get; set; }

    public int IdEnvioCorreo { get; set; }

    public string GenEnvioCorreoEnvioCorreo { get; set; } = null!;

    public string? GenEnvioCorreoEnvioCorreoCodigo { get; set; }

    public int GenEnvioCorreoEstrategia { get; set; }

    public string GenEnvioCorreoTabla { get; set; } = null!;

    public int GenEnvioCorreoIdReporte { get; set; }

    public string? GenEnvioCorreoCorreoAdicional { get; set; }

    public string? GenEnvioCorreoPlantillaAdjunto { get; set; }

    public int GenEnvioCorreoIdSubtipoDocumento { get; set; }

    public int GenEnvioCorreoIdEstadoTipoDocumento { get; set; }

    public string Multiempresa { get; set; } = null!;
}
