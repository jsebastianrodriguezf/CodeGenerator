namespace SAMMAI.Transverse.Models.Objects;

public class ViewCatVersionEquipoDetalleTemparioObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string VersionEquipoDetalleTempario { get; set; } = null!;
    public int IdDetalleTempario { get; set; }
    public string CatDetalleTemparioDetalleTempario { get; set; } = null!;
    public string? CatDetalleTemparioDetalleTemparioCodigo { get; set; }
    public double CatDetalleTemparioCantidadEstandar { get; set; }
    public int CatDetalleTemparioOrden { get; set; }
    public double CatDetalleTemparioCantidadTropicalizada { get; set; }
    public int CatDetalleTemparioIdCatalogo { get; set; }
    public int CatDetalleTemparioIdCatalogoTempario { get; set; }
    public int CatDetalleTemparioIdPruebaCheckList { get; set; }
    public int CatDetalleTemparioIdSistema { get; set; }
    public int CatDetalleTemparioIdDetalleTemparioPadre { get; set; }
    public int IdVersionEquipo { get; set; }
    public string CatVersionEquipoVersionEquipo { get; set; } = null!;
    public string? CatVersionEquipoVersionEquipoCodigo { get; set; }
    public int CatVersionEquipoIdCatalogoEquipo { get; set; }
    public string Multiempresa { get; set; } = null!;
}
