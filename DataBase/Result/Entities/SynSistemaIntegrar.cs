namespace SAMMAI.DataBase.Repository.Entities;

public partial class SynSistemaIntegrar : SynSistemaIntegrarObject
{
    public virtual SynTipoAutenticacion IdTipoAutenticacionNavigation { get; set; } = null!;
    public virtual ICollection<SynPuntoIntegracion> SynPuntoIntegracions { get; set; } = new List<SynPuntoIntegracion>();
}
