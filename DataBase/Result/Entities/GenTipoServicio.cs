namespace SAMMAI.DataBase.Repository.Entities;

public partial class GenTipoServicio : GenTipoServicioObject
{
    public virtual ICollection<CatCatalogoTempario> CatCatalogoTemparios { get; set; } = new List<CatCatalogoTempario>();
    public virtual ICollection<CatTarifa> CatTarifas { get; set; } = new List<CatTarifa>();
    public virtual ICollection<CntContratoTipoServicio> CntContratoTipoServicios { get; set; } = new List<CntContratoTipoServicio>();
    public virtual ICollection<CntContrato> CntContratos { get; set; } = new List<CntContrato>();
    public virtual ICollection<DocDocumentoOt> DocDocumentoOts { get; set; } = new List<DocDocumentoOt>();
    public virtual ICollection<GenConfiguracionServicio> GenConfiguracionServicios { get; set; } = new List<GenConfiguracionServicio>();
    public virtual ICollection<SegUsuarioCatalogoEquipo> SegUsuarioCatalogoEquipos { get; set; } = new List<SegUsuarioCatalogoEquipo>();
}
