namespace SAMMAI.DataBase.Repository.Entities;

public partial class EquPagoAlquiler : EquPagoAlquilerObject
{
    public virtual ICollection<EquDetallePagoAlquiler> EquDetallePagoAlquilers { get; set; } = new List<EquDetallePagoAlquiler>();
    public virtual DocDocumentoAlquiler IdDocumentoAlquilerNavigation { get; set; } = null!;
}
