using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class DisEventoCatalogo
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string EventoCatalogo { get; set; } = null!;

    public bool EquipoAuxiliar { get; set; }

    public double? Cantidad { get; set; }

    public double? ValorUnitario { get; set; }

    public double? Total { get; set; }

    public int IdEvento { get; set; }

    public int IdCatalogo { get; set; }

    public string Observaciones { get; set; } = null!;

    public virtual CatCatalogo IdCatalogoNavigation { get; set; } = null!;

    public virtual DisEvento IdEventoNavigation { get; set; } = null!;
}
