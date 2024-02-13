using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class CatMarca
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string Marca { get; set; } = null!;

    public string? MarcaCodigo { get; set; }

    public int IdTerceroFabricante { get; set; }

    public virtual ICollection<CatCatalogoEquipo> CatCatalogoEquipos { get; set; } = new List<CatCatalogoEquipo>();

    public virtual ICollection<CatCatalogoRepuesto> CatCatalogoRepuestos { get; set; } = new List<CatCatalogoRepuesto>();

    public virtual ICollection<CatTarifa> CatTarifas { get; set; } = new List<CatTarifa>();

    public virtual TerTercero IdTerceroFabricanteNavigation { get; set; } = null!;
}
