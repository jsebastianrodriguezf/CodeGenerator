using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class CatCatalogoEquipoPruebaCheckList
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string CatalogoEquipoPruebaCheckList { get; set; } = null!;

    public int IdPruebaCheckList { get; set; }

    public int IdCatalogoEquipo { get; set; }

    public virtual CatCatalogoEquipo IdCatalogoEquipoNavigation { get; set; } = null!;

    public virtual CatPruebaCheckList IdPruebaCheckListNavigation { get; set; } = null!;
}
