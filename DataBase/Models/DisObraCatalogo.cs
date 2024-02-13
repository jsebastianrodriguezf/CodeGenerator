using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class DisObraCatalogo
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string ObraCatalogo { get; set; } = null!;

    public double Cantidad { get; set; }

    public double ValorUnitario { get; set; }

    public double Total { get; set; }

    public double PromedioDia { get; set; }

    public int IdObra { get; set; }

    public int IdCatalogo { get; set; }

    public double? ValorMaximo { get; set; }

    public double? ValorMinimo { get; set; }

    public virtual CatCatalogo IdCatalogoNavigation { get; set; } = null!;

    public virtual DisObra IdObraNavigation { get; set; } = null!;
}
