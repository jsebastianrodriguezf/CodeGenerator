using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class VDocPruebaSop
{
    public int Id { get; set; }

    public int IdUsuarioCreo { get; set; }

    public string Cuerpo { get; set; } = null!;
}
