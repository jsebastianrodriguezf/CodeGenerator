using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class RepCategorium
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string Categoria { get; set; } = null!;

    public string? CategoriaCodigo { get; set; }

    public int IdCategoria { get; set; }

    public virtual RepCategorium IdCategoriaNavigation { get; set; } = null!;

    public virtual ICollection<RepCategorium> InverseIdCategoriaNavigation { get; set; } = new List<RepCategorium>();

    public virtual ICollection<RepReporteCategorium> RepReporteCategoria { get; set; } = new List<RepReporteCategorium>();
}
