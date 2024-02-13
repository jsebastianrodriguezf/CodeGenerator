using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class GasGasto
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string Gasto { get; set; } = null!;

    public string? GastoCodigo { get; set; }

    public int Numero { get; set; }

    public DateTime FechaFf { get; set; }

    public int Dias { get; set; }

    public double Valor { get; set; }

    public string Concepto { get; set; } = null!;

    public bool Consignado { get; set; }

    public int IdTipoGasto { get; set; }

    public int IdUsuarioAprobo { get; set; }

    public int IdUsuarioSolicitante { get; set; }

    public int IdEstadoTipoDocumento { get; set; }

    public virtual ICollection<GasDetalleGasto> GasDetalleGastos { get; set; } = new List<GasDetalleGasto>();

    public virtual DocEstadoTipoDocumento IdEstadoTipoDocumentoNavigation { get; set; } = null!;

    public virtual GasTipoGasto IdTipoGastoNavigation { get; set; } = null!;

    public virtual SegUsuario IdUsuarioAproboNavigation { get; set; } = null!;

    public virtual SegUsuario IdUsuarioSolicitanteNavigation { get; set; } = null!;

    public virtual ICollection<OrtReporteTecnico> OrtReporteTecnicos { get; set; } = new List<OrtReporteTecnico>();
}
