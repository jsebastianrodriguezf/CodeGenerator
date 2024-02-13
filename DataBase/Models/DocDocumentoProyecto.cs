using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class DocDocumentoProyecto
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string DocumentoProyecto { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public DateTime FechaInicioEstimada { get; set; }

    public DateTime FechaFinEstimada { get; set; }

    public string? Descripcion { get; set; }

    public decimal? Presupuesto { get; set; }

    public virtual ICollection<DocDocumentoProyectoEjecutore> DocDocumentoProyectoEjecutores { get; set; } = new List<DocDocumentoProyectoEjecutore>();

    public virtual ICollection<DocDocumentoProyectoEntregable> DocDocumentoProyectoEntregables { get; set; } = new List<DocDocumentoProyectoEntregable>();

    public virtual ICollection<DocDocumentoProyectoEtapa> DocDocumentoProyectoEtapas { get; set; } = new List<DocDocumentoProyectoEtapa>();

    public virtual ICollection<DocDocumentoProyectoSucursal> DocDocumentoProyectoSucursals { get; set; } = new List<DocDocumentoProyectoSucursal>();

    public virtual ICollection<ProHito> ProHitos { get; set; } = new List<ProHito>();

    public virtual ICollection<ProHorarioProyecto> ProHorarioProyectos { get; set; } = new List<ProHorarioProyecto>();
}
