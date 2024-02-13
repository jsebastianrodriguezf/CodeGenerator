using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class EquPagoAlquiler
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string PagoAlquiler { get; set; } = null!;

    public string? PagoAlquilerCodigo { get; set; }

    public decimal ValorPorCobrar { get; set; }

    public decimal? ValorFacturado { get; set; }

    public string? NumeroFactura { get; set; }

    public DateTime FechaEsperadaPagoFf { get; set; }

    public DateTime? FechaFacturaFf { get; set; }

    public int IdDocumentoAlquiler { get; set; }

    public virtual ICollection<EquDetallePagoAlquiler> EquDetallePagoAlquilers { get; set; } = new List<EquDetallePagoAlquiler>();

    public virtual DocDocumentoAlquiler IdDocumentoAlquilerNavigation { get; set; } = null!;
}
