namespace SAMMAI.DataBase.Repository.Entities;

public partial class SegRegistroIntegracion : SegRegistroIntegracionObject
{
    public virtual SynPuntoIntegracion IdPuntoIntegracionNavigation { get; set; } = null!;
}
