namespace SAMMAI.DataBase.Repository.Entities;

public partial class SynTipoAutenticacion : SynTipoAutenticacionObject
{
    public virtual ICollection<SynSistemaIntegrar> SynSistemaIntegrars { get; set; } = new List<SynSistemaIntegrar>();
}
