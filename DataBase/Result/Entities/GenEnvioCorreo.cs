namespace SAMMAI.DataBase.Repository.Entities;

public partial class GenEnvioCorreo : GenEnvioCorreoObject
{
    public virtual ICollection<GenRegistroEnvio> GenRegistroEnvios { get; set; } = new List<GenRegistroEnvio>();
    public virtual DocEstadoTipoDocumento IdEstadoTipoDocumentoNavigation { get; set; } = null!;
    public virtual GenRemitenteCorreo? IdRemitenteCorreoNavigation { get; set; }
    public virtual RepReporte IdReporteNavigation { get; set; } = null!;
    public virtual DocSubtipoDocumento IdSubtipoDocumentoNavigation { get; set; } = null!;
    public virtual ICollection<SegCargoEnvioCorreo> SegCargoEnvioCorreos { get; set; } = new List<SegCargoEnvioCorreo>();
}
