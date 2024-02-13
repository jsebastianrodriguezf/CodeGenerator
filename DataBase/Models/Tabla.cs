using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class Tabla
{
    public int Id { get; set; }

    public string Tabla1 { get; set; } = null!;

    public virtual ICollection<Columna> Columnas { get; set; } = new List<Columna>();

    public virtual ICollection<GenConfiguracionAtributo> GenConfiguracionAtributoIdTablaRelacionNavigations { get; set; } = new List<GenConfiguracionAtributo>();

    public virtual ICollection<GenConfiguracionAtributo> GenConfiguracionAtributoIdTablaResultadoNavigations { get; set; } = new List<GenConfiguracionAtributo>();
}
