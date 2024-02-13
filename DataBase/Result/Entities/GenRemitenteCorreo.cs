namespace SAMMAI.DataBase.Repository.Entities;

public partial class GenRemitenteCorreo : GenRemitenteCorreoObject
{
    public virtual ICollection<GenEnvioCorreo> GenEnvioCorreos { get; set; } = new List<GenEnvioCorreo>();
}
