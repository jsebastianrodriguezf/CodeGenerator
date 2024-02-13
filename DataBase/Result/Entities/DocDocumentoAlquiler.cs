namespace SAMMAI.DataBase.Repository.Entities;

public partial class DocDocumentoAlquiler : DocDocumentoAlquilerObject
{
    public virtual ICollection<CntContrato> CntContratos { get; set; } = new List<CntContrato>();
    public virtual ICollection<EquDetalleAlquiler> EquDetalleAlquilers { get; set; } = new List<EquDetalleAlquiler>();
    public virtual ICollection<EquPagoAlquiler> EquPagoAlquilers { get; set; } = new List<EquPagoAlquiler>();
    public virtual ICollection<EquTrazabilidad> EquTrazabilidads { get; set; } = new List<EquTrazabilidad>();
}
