using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class GenPresupuestoEmpresa
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string PresupuestoEmpresa { get; set; } = null!;

    public string? PresupuestoEmpresaCodigo { get; set; }

    public DateTime FechaInicioFf { get; set; }

    public DateTime FechaFinFf { get; set; }

    public decimal Valor { get; set; }

    public int IdEmpresa { get; set; }

    public virtual GenEmpresa IdEmpresaNavigation { get; set; } = null!;
}
