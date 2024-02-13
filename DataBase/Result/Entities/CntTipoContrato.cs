namespace SAMMAI.DataBase.Repository.Entities;

public partial class CntTipoContrato : CntTipoContratoObject
{
    public virtual ICollection<CntContrato> CntContratos { get; set; } = new List<CntContrato>();
}
