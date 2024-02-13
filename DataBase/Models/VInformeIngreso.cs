using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class VInformeIngreso
{
    public int Id { get; set; }

    public string? Encabezado { get; set; }

    public string Cuerpo { get; set; } = null!;

    public string? Email { get; set; }
}
