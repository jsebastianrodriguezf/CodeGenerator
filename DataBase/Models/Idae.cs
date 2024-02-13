using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class Idae
{
    public string K { get; set; } = null!;

    public string V { get; set; } = null!;

    public DateTime FechaModificacion { get; set; }

    public int IdUsuarioModifico { get; set; }
}
