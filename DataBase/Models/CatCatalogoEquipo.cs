using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class CatCatalogoEquipo
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string CatalogoEquipo { get; set; } = null!;

    public int? GarantiaMeses { get; set; }

    public int? GarantiaHoras { get; set; }

    public bool ManejaHorometro { get; set; }

    public int IdMarca { get; set; }

    public virtual ICollection<CatCatalogoEquipoCatalogoTempario> CatCatalogoEquipoCatalogoTemparios { get; set; } = new List<CatCatalogoEquipoCatalogoTempario>();

    public virtual ICollection<CatCatalogoEquipoPruebaCheckList> CatCatalogoEquipoPruebaCheckLists { get; set; } = new List<CatCatalogoEquipoPruebaCheckList>();

    public virtual ICollection<CatPosicion> CatPosicionIdCatalogoEquipoComponenteNavigations { get; set; } = new List<CatPosicion>();

    public virtual ICollection<CatPosicion> CatPosicionIdCatalogoEquipoEquipoNavigations { get; set; } = new List<CatPosicion>();

    public virtual ICollection<CatReemplazoCatalogoEquipo> CatReemplazoCatalogoEquipos { get; set; } = new List<CatReemplazoCatalogoEquipo>();

    public virtual ICollection<CatSistemaCatalogoEquipo> CatSistemaCatalogoEquipos { get; set; } = new List<CatSistemaCatalogoEquipo>();

    public virtual ICollection<CatTarifa> CatTarifas { get; set; } = new List<CatTarifa>();

    public virtual ICollection<CatVersionEquipo> CatVersionEquipos { get; set; } = new List<CatVersionEquipo>();

    public virtual ICollection<EquAnalisisFalla> EquAnalisisFallas { get; set; } = new List<EquAnalisisFalla>();

    public virtual ICollection<EquEquipo> EquEquipos { get; set; } = new List<EquEquipo>();

    public virtual CatMarca IdMarcaNavigation { get; set; } = null!;

    public virtual ICollection<SegUsuarioCatalogoEquipo> SegUsuarioCatalogoEquipos { get; set; } = new List<SegUsuarioCatalogoEquipo>();
}
