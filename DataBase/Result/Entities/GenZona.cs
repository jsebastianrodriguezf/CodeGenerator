namespace SAMMAI.DataBase.Repository.Entities;

public partial class GenZona : GenZonaObject
{
    public virtual ICollection<CatTarifa> CatTarifas { get; set; } = new List<CatTarifa>();
    public virtual ICollection<CntContratoZona> CntContratoZonas { get; set; } = new List<CntContratoZona>();
    public virtual ICollection<ComComision> ComComisions { get; set; } = new List<ComComision>();
    public virtual ICollection<DocDocumentoOt> DocDocumentoOts { get; set; } = new List<DocDocumentoOt>();
    public virtual ICollection<DocDocumentoSolicitud> DocDocumentoSolicituds { get; set; } = new List<DocDocumentoSolicitud>();
    public virtual ICollection<EquEquipo> EquEquipos { get; set; } = new List<EquEquipo>();
    public virtual GenZona IdZonaNavigation { get; set; } = null!;
    public virtual ICollection<GenZona> InverseIdZonaNavigation { get; set; } = new List<GenZona>();
    public virtual ICollection<SegUsuario> SegUsuarios { get; set; } = new List<SegUsuario>();
    public virtual ICollection<TerSucursal> TerSucursals { get; set; } = new List<TerSucursal>();
    public virtual ICollection<TerTercero> TerTerceros { get; set; } = new List<TerTercero>();
}
