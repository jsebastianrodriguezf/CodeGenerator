namespace SAMMAI.DataBase.Repository.Entities;

public partial class CntPeriodoContrato : CntPeriodoContratoObject
{
    public virtual ICollection<CntContrato> CntContratos { get; set; } = new List<CntContrato>();
}
