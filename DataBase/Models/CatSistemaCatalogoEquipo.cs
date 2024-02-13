using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class CatSistemaCatalogoEquipo
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string SistemaCatalogoEquipo { get; set; } = null!;

    public int IdCatalogoEquipo { get; set; }

    public int IdSistema { get; set; }

    public int IdVersionEquipo { get; set; }

    public virtual CatCatalogoEquipo IdCatalogoEquipoNavigation { get; set; } = null!;

    public virtual CatSistema IdSistemaNavigation { get; set; } = null!;

    public virtual CatVersionEquipo IdVersionEquipoNavigation { get; set; } = null!;
}
