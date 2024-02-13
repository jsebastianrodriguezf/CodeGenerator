using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class VAlquileresPreliquidar
{
    public int IdAlquiler { get; set; }

    public string? FechaAlq { get; set; }

    public DateTime? UltimaFactura { get; set; }
}
