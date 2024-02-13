namespace SAMMAI.DataBase.Repository.Entities;

public partial class CntPagosContrato : CntPagosContratoObject
{
    public virtual CntContrato IdContratoNavigation { get; set; } = null!;
}
