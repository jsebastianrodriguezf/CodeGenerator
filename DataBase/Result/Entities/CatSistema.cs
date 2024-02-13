namespace SAMMAI.DataBase.Repository.Entities;

public partial class CatSistema : CatSistemaObject
{
    public virtual ICollection<CatDetalleTempario> CatDetalleTemparios { get; set; } = new List<CatDetalleTempario>();
    public virtual ICollection<CatSistemaCatalogoEquipo> CatSistemaCatalogoEquipos { get; set; } = new List<CatSistemaCatalogoEquipo>();
    public virtual ICollection<DisEventoEstadoEvento> DisEventoEstadoEventos { get; set; } = new List<DisEventoEstadoEvento>();
    public virtual ICollection<DocDocumentoOt> DocDocumentoOts { get; set; } = new List<DocDocumentoOt>();
    public virtual ICollection<EquEquipo> EquEquipos { get; set; } = new List<EquEquipo>();
    public virtual CatSistema IdSistemaNavigation { get; set; } = null!;
    public virtual ICollection<CatSistema> InverseIdSistemaNavigation { get; set; } = new List<CatSistema>();
}
