using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ProEntregable
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string Entregable { get; set; } = null!;

    public string? EntregableCodigo { get; set; }

    public string Nombre { get; set; } = null!;

    public string Producto { get; set; } = null!;

    public DateTime FechaPlaneada { get; set; }

    public DateTime FechaProyectada { get; set; }

    public DateTime FechaReal { get; set; }

    public bool EsExterno { get; set; }

    public double PorcentajePlaneado { get; set; }

    public int ValorPlaneado { get; set; }

    public double PorcentajeReal { get; set; }

    public int ValorReal { get; set; }

    public virtual ICollection<DocDocumentoProyectoEntregable> DocDocumentoProyectoEntregables { get; set; } = new List<DocDocumentoProyectoEntregable>();
}
