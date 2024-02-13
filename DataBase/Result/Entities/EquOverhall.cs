namespace SAMMAI.DataBase.Repository.Entities;

public partial class EquOverhall : EquOverhallObject
{
    public virtual DocDocumentoOt IdDocumentoOtNavigation { get; set; } = null!;
    public virtual EquEquipo IdEquipoNavigation { get; set; } = null!;
}
