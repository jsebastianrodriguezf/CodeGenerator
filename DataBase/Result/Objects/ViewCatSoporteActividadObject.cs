namespace SAMMAI.Transverse.Models.Objects;

public class ViewCatSoporteActividadObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string SoporteActividad { get; set; } = null!;
    public string? SoporteActividadCodigo { get; set; }
    public double Duracion { get; set; }
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
    public int IdCargo { get; set; }
    public string SegCargoCargo { get; set; } = null!;
    public string? SegCargoCargoCodigo { get; set; }
    public bool? SegCargoEsTecnico { get; set; }
    public bool? SegCargoEsComercial { get; set; }
    public bool? SegCargoEsCoordinador { get; set; }
    public decimal? SegCargoValorHora { get; set; }
    public bool SegCargoEsAdministrativo { get; set; }
    public string Multiempresa { get; set; } = null!;
}
