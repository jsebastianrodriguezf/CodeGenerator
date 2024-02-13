namespace SAMMAI.DataBase.Repository.Entities;

public partial class SynCampoIntegracion : SynCampoIntegracionObject
{
    public virtual SynPuntoIntegracion? IdPuntoIntegracionNavigation { get; set; }
}
