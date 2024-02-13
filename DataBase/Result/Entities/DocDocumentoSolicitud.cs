namespace SAMMAI.DataBase.Repository.Entities;

public partial class DocDocumentoSolicitud : DocDocumentoSolicitudObject
{
    public virtual OrtDepartamentoSolicitud IdDepartamentoSolicitudNavigation { get; set; } = null!;
    public virtual EquEquipo IdEquipoNavigation { get; set; } = null!;
    public virtual DocMedioSolicitud IdMedioSolicitudNavigation { get; set; } = null!;
    public virtual TerSucursal IdSucursalNavigation { get; set; } = null!;
    public virtual GenZona IdZonaNavigation { get; set; } = null!;
}
