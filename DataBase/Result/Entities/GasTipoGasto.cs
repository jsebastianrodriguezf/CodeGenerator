namespace SAMMAI.DataBase.Repository.Entities;

public partial class GasTipoGasto : GasTipoGastoObject
{
    public virtual ICollection<GasGasto> GasGastos { get; set; } = new List<GasGasto>();
}
