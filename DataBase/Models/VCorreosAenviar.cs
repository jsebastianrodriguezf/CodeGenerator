using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class VCorreosAenviar
{
    public int Id { get; set; }

    public string Os { get; set; } = null!;

    public string SerialEquipo { get; set; } = null!;

    public int IdDocumento { get; set; }
}
