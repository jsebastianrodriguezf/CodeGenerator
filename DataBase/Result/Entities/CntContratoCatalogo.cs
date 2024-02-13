namespace SAMMAI.DataBase.Repository.Entities;

public partial class CntContratoCatalogo : CntContratoCatalogoObject
{
    public virtual CatCatalogo IdCatalogoNavigation { get; set; } = null!;
    public virtual CntContrato IdContratoNavigation { get; set; } = null!;
}
