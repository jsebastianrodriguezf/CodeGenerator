namespace SAMMAI.DataBase.Repository.Entities;

public partial class EquDetallePagoAlquiler : EquDetallePagoAlquilerObject
{
    public virtual DocDocumento? IdDocumentoNavigation { get; set; }
    public virtual EquEquipo IdEquipoNavigation { get; set; } = null!;
    public virtual DocItemDocumento IdItemDocumentoNavigation { get; set; } = null!;
    public virtual EquPagoAlquiler IdPagoAlquilerNavigation { get; set; } = null!;
}
