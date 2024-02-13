namespace SAMMAI.DataBase.Repository.Entities;

public partial class EquTipoFalla : EquTipoFallaObject
{
    public virtual ICollection<EquFalla> EquFallas { get; set; } = new List<EquFalla>();
}
