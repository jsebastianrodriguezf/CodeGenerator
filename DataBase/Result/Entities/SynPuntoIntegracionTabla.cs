namespace SAMMAI.DataBase.Repository.Entities;

public partial class SynPuntoIntegracionTabla : SynPuntoIntegracionTablaObject
{
    public virtual SynPuntoIntegracion IdPuntoIntegracionNavigation { get; set; } = null!;
}
