using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class CatSistema
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string Sistema { get; set; } = null!;

    public string? SistemaCodigo { get; set; }

    public int IdSistema { get; set; }

    public virtual ICollection<CatDetalleTempario> CatDetalleTemparios { get; set; } = new List<CatDetalleTempario>();

    public virtual ICollection<CatSistemaCatalogoEquipo> CatSistemaCatalogoEquipos { get; set; } = new List<CatSistemaCatalogoEquipo>();

    public virtual ICollection<DisEventoEstadoEvento> DisEventoEstadoEventos { get; set; } = new List<DisEventoEstadoEvento>();

    public virtual ICollection<DocDocumentoOt> DocDocumentoOts { get; set; } = new List<DocDocumentoOt>();

    public virtual ICollection<EquEquipo> EquEquipos { get; set; } = new List<EquEquipo>();

    public virtual CatSistema IdSistemaNavigation { get; set; } = null!;

    public virtual ICollection<CatSistema> InverseIdSistemaNavigation { get; set; } = new List<CatSistema>();
}
