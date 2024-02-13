using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class DisObra
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string Obra { get; set; } = null!;

    public string? ObraCodigo { get; set; }

    public DateTime FechaInicialFf { get; set; }

    public DateTime? FechaFinalFf { get; set; }

    public int IdSucursal { get; set; }

    public virtual ICollection<DisObraCatalogo> DisObraCatalogos { get; set; } = new List<DisObraCatalogo>();

    public virtual ICollection<DisObraEquipo> DisObraEquipos { get; set; } = new List<DisObraEquipo>();

    public virtual TerSucursal IdSucursalNavigation { get; set; } = null!;
}
