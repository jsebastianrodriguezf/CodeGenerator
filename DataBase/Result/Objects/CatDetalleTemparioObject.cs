namespace SAMMAI.Transverse.Models.Objects;

public class CatDetalleTemparioObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string DetalleTempario { get; set; } = null!;
    public string? DetalleTemparioCodigo { get; set; }
    public double CantidadEstandar { get; set; }
    public int Orden { get; set; }
    public double CantidadTropicalizada { get; set; }
    public int IdCatalogo { get; set; }
    public int IdCatalogoTempario { get; set; }
    public int IdPruebaCheckList { get; set; }
    public int IdSistema { get; set; }
    public int IdDetalleTemparioPadre { get; set; }
}
