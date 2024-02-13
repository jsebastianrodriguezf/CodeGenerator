namespace SAMMAI.DataBase.Repository.Entities;

public partial class Tabla : TablaObject
{
    public virtual ICollection<Columna> Columnas { get; set; } = new List<Columna>();
    public virtual ICollection<GenConfiguracionAtributo> GenConfiguracionAtributoIdTablaRelacionNavigations { get; set; } = new List<GenConfiguracionAtributo>();
    public virtual ICollection<GenConfiguracionAtributo> GenConfiguracionAtributoIdTablaResultadoNavigations { get; set; } = new List<GenConfiguracionAtributo>();
}
