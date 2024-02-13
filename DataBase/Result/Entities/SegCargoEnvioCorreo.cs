namespace SAMMAI.DataBase.Repository.Entities;

public partial class SegCargoEnvioCorreo : SegCargoEnvioCorreoObject
{
    public virtual SegCargo IdCargoNavigation { get; set; } = null!;
    public virtual GenEnvioCorreo IdEnvioCorreoNavigation { get; set; } = null!;
}
