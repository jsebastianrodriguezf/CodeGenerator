using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class CatDetalleTempario
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string DetalleTempario { get; set; } = null!;

    public string? DetalleTemparioCodigo { get; set; }

    public double CantidadEstandar { get; set; }

    public int Orden { get; set; }

    public double CantidadTropicalizada { get; set; }

    public int IdCatalogo { get; set; }

    public int IdCatalogoTempario { get; set; }

    public int IdPruebaCheckList { get; set; }

    public int IdSistema { get; set; }

    public int IdDetalleTemparioPadre { get; set; }

    public virtual ICollection<CatSoporteActividad> CatSoporteActividads { get; set; } = new List<CatSoporteActividad>();

    public virtual ICollection<CatVersionEquipoDetalleTempario> CatVersionEquipoDetalleTemparios { get; set; } = new List<CatVersionEquipoDetalleTempario>();

    public virtual CatCatalogo IdCatalogoNavigation { get; set; } = null!;

    public virtual CatCatalogoTempario IdCatalogoTemparioNavigation { get; set; } = null!;

    public virtual CatDetalleTempario IdDetalleTemparioPadreNavigation { get; set; } = null!;

    public virtual CatPruebaCheckList IdPruebaCheckListNavigation { get; set; } = null!;

    public virtual CatSistema IdSistemaNavigation { get; set; } = null!;

    public virtual ICollection<CatDetalleTempario> InverseIdDetalleTemparioPadreNavigation { get; set; } = new List<CatDetalleTempario>();
}
