using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class CatCatalogoEquipoCatalogoTempario
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string CatalogoEquipoCatalogoTempario { get; set; } = null!;

    public int IdCatalogoEquipo { get; set; }

    public int IdCatalogoTempario { get; set; }

    public virtual CatCatalogoEquipo IdCatalogoEquipoNavigation { get; set; } = null!;

    public virtual CatCatalogoTempario IdCatalogoTemparioNavigation { get; set; } = null!;
}
