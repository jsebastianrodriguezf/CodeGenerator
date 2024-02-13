using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ProRecursoFisico
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string RecursoFisico { get; set; } = null!;

    public string? RecursoFisicoCodigo { get; set; }

    public double Costo { get; set; }

    public string UnidadTiempo { get; set; } = null!;

    public bool EsPropio { get; set; }

    public int IdEquipo { get; set; }

    public int IdCatalogo { get; set; }

    public virtual CatCatalogo IdCatalogoNavigation { get; set; } = null!;

    public virtual EquEquipo IdEquipoNavigation { get; set; } = null!;

    public virtual ICollection<ProActividadRecursoFisico> ProActividadRecursoFisicos { get; set; } = new List<ProActividadRecursoFisico>();
}
