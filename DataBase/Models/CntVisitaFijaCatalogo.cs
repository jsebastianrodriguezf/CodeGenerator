using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class CntVisitaFijaCatalogo
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string VisitaFijaCatalogo { get; set; } = null!;

    public double Cantidad { get; set; }

    public double Precio { get; set; }

    public int IdVisitaFija { get; set; }

    public int IdCatalogo { get; set; }

    public virtual CatCatalogo IdCatalogoNavigation { get; set; } = null!;

    public virtual CntVisitaFija IdVisitaFijaNavigation { get; set; } = null!;
}
