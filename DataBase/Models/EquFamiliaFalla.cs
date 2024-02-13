using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class EquFamiliaFalla
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string FamiliaFalla { get; set; } = null!;

    public int IdFamilia { get; set; }

    public int IdFalla { get; set; }

    public virtual EquFalla IdFallaNavigation { get; set; } = null!;

    public virtual GenFamilium IdFamiliaNavigation { get; set; } = null!;
}
