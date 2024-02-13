namespace SAMMAI.DataBase.Repository.Entities;

public partial class AlqHistoricoAlquiler : AlqHistoricoAlquilerObject
{
    public virtual DocDocumento? IdDocumentoNavigation { get; set; }
    public virtual EquEquipo? IdEquipoNavigation { get; set; }
    public virtual EquEstadoEquipo? IdEstadoEquipoNavigation { get; set; }
}
