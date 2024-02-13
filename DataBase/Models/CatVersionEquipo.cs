using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class CatVersionEquipo
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string VersionEquipo { get; set; } = null!;

    public string? VersionEquipoCodigo { get; set; }

    public int IdCatalogoEquipo { get; set; }

    public virtual ICollection<CatReemplazoCatalogoEquipo> CatReemplazoCatalogoEquipos { get; set; } = new List<CatReemplazoCatalogoEquipo>();

    public virtual ICollection<CatSistemaCatalogoEquipo> CatSistemaCatalogoEquipos { get; set; } = new List<CatSistemaCatalogoEquipo>();

    public virtual ICollection<CatVersionEquipoDetalleTempario> CatVersionEquipoDetalleTemparios { get; set; } = new List<CatVersionEquipoDetalleTempario>();

    public virtual ICollection<EquEquipo> EquEquipos { get; set; } = new List<EquEquipo>();

    public virtual CatCatalogoEquipo IdCatalogoEquipoNavigation { get; set; } = null!;
}
