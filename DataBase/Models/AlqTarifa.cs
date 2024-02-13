using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class AlqTarifa
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string Tarifa { get; set; } = null!;

    public string? TarifaCodigo { get; set; }

    public int IdItemDocumento { get; set; }

    public int IdDetalleAlquiler { get; set; }

    public int IdTipoTarifa { get; set; }

    public double HorasIncluidas { get; set; }

    public int CantidadIncluida { get; set; }

    public virtual ICollection<AlqDetalleLiquidacion> AlqDetalleLiquidacions { get; set; } = new List<AlqDetalleLiquidacion>();

    public virtual EquDetalleAlquiler IdDetalleAlquilerNavigation { get; set; } = null!;

    public virtual DocItemDocumento IdItemDocumentoNavigation { get; set; } = null!;

    public virtual AlqTipoTarifa IdTipoTarifaNavigation { get; set; } = null!;
}
