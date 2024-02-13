namespace SAMMAI.DataBase.Repository.Entities;

public partial class EquEquipoItemDocumento : EquEquipoItemDocumentoObject
{
    public virtual CatCatalogo IdCatalogoNavigation { get; set; } = null!;
    public virtual EquEquipo IdEquipoNavigation { get; set; } = null!;
    public virtual DocItemDocumento IdItemDocumentoNavigation { get; set; } = null!;
}
