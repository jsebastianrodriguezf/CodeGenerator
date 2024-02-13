namespace SAMMAI.DataBase.Repository.Entities;

public partial class GenRegistroEnvio : GenRegistroEnvioObject
{
    public virtual ICollection<GenDetalleRegistroEnvio> GenDetalleRegistroEnvios { get; set; } = new List<GenDetalleRegistroEnvio>();
    public virtual GenEnvioCorreo IdEnvioCorreoNavigation { get; set; } = null!;
    public virtual GenRegistroEnvio IdRegistroEnvioNavigation { get; set; } = null!;
    public virtual ICollection<GenRegistroEnvio> InverseIdRegistroEnvioNavigation { get; set; } = new List<GenRegistroEnvio>();
}
