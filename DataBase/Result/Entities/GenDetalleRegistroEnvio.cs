namespace SAMMAI.DataBase.Repository.Entities;

public partial class GenDetalleRegistroEnvio : GenDetalleRegistroEnvioObject
{
    public virtual GenRegistroEnvio IdRegistroEnvioNavigation { get; set; } = null!;
}
