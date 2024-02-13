using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class CntPagosContrato
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string PagosContrato { get; set; } = null!;

    public string? PagosContratoCodigo { get; set; }

    public DateTime FechaFf { get; set; }

    public decimal Valor { get; set; }

    public int IdContrato { get; set; }

    public virtual CntContrato IdContratoNavigation { get; set; } = null!;
}
