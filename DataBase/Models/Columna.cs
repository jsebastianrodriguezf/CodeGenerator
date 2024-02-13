using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class Columna
{
    public int Id { get; set; }

    public string Columna1 { get; set; } = null!;

    public string Tipo { get; set; } = null!;

    public int Tamano { get; set; }

    public bool EsNuleable { get; set; }

    public int IdTabla { get; set; }

    public virtual ICollection<GenDetalleFormulario> GenDetalleFormularios { get; set; } = new List<GenDetalleFormulario>();

    public virtual Tabla IdTablaNavigation { get; set; } = null!;
}
