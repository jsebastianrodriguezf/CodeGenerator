namespace SAMMAI.DataBase.Repository.Entities;

public partial class DisEvento : DisEventoObject
{
    public virtual ICollection<AlqDetalleLiquidacion> AlqDetalleLiquidacions { get; set; } = new List<AlqDetalleLiquidacion>();
    public virtual ICollection<DisEventoCatalogo> DisEventoCatalogos { get; set; } = new List<DisEventoCatalogo>();
    public virtual ICollection<DisEventoEstadoEvento> DisEventoEstadoEventos { get; set; } = new List<DisEventoEstadoEvento>();
    public virtual ICollection<EquEquipoAtributo> EquEquipoAtributos { get; set; } = new List<EquEquipoAtributo>();
    public virtual ICollection<EquTrazabilidad> EquTrazabilidads { get; set; } = new List<EquTrazabilidad>();
    public virtual EquEquipo IdEquipoNavigation { get; set; } = null!;
    public virtual EquEstadoEquipo IdEstadoEquipoNavigation { get; set; } = null!;
    public virtual DisEstadoEvento IdEstadoEventoNavigation { get; set; } = null!;
    public virtual EquFalla IdFallaCausaNavigation { get; set; } = null!;
    public virtual EquFalla IdFallaNavigation { get; set; } = null!;
    public virtual DisMetodoDeteccion IdMetodoDeteccionNavigation { get; set; } = null!;
    public virtual DisMotivoEvento IdMotivoEventoNavigation { get; set; } = null!;
    public virtual SegUsuario IdUsuarioNavigation { get; set; } = null!;
}
