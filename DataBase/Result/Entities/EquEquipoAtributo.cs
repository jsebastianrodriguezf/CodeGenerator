namespace SAMMAI.DataBase.Repository.Entities;

public partial class EquEquipoAtributo : EquEquipoAtributoObject
{
    public virtual CatAtributo IdAtributoNavigation { get; set; } = null!;
    public virtual DocDocumentoOt IdDocumentoOtNavigation { get; set; } = null!;
    public virtual EquEquipo IdEquipoNavigation { get; set; } = null!;
    public virtual DisEvento IdEventoNavigation { get; set; } = null!;
    public virtual EquOpcionAtributo IdOpcionAtributoNavigation { get; set; } = null!;
    public virtual OrtReporteTecnico IdReporteTecnicoNavigation { get; set; } = null!;
}
