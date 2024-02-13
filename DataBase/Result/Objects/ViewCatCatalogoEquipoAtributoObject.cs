namespace SAMMAI.Transverse.Models.Objects;

public class ViewCatCatalogoEquipoAtributoObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string? CatalogoEquipoAtributo { get; set; }
    public double ValorMinimo { get; set; }
    public double ValorMaximo { get; set; }
    public bool BloquearCierreOt { get; set; }
    public int IdAtributo { get; set; }
    public string CatAtributoAtributo { get; set; } = null!;
    public string? CatAtributoAtributoCodigo { get; set; }
    public bool CatAtributoEsVariable { get; set; }
    public bool CatAtributoResaltado { get; set; }
    public double? CatAtributoValorMinimo { get; set; }
    public double? CatAtributoValorMaximo { get; set; }
    public int CatAtributoIdSeccionAtributo { get; set; }
    public int CatAtributoIdTipoAtributo { get; set; }
    public int CatAtributoIdUnidad { get; set; }
    public string CatAtributoNombreControl { get; set; } = null!;
    public bool CatAtributoEsObligatorio { get; set; }
    public int IdCatalogoEquipo { get; set; }
    public string CatCatalogoEquipoCatalogoEquipo { get; set; } = null!;
    public int? CatCatalogoEquipoGarantiaMeses { get; set; }
    public int? CatCatalogoEquipoGarantiaHoras { get; set; }
    public bool CatCatalogoEquipoManejaHorometro { get; set; }
    public int CatCatalogoEquipoIdMarca { get; set; }
    public string? CatCatalogoEquipoCatalogoCodigo { get; set; }
    public string CatCatalogoEquipoCodigoInventario { get; set; } = null!;
    public decimal? CatCatalogoEquipoPrecioVenta { get; set; }
    public int? CatCatalogoEquipoTiempoConsecucion { get; set; }
    public bool CatCatalogoEquipoEsNacional { get; set; }
    public int CatCatalogoEquipoIdFamilia { get; set; }
    public int CatCatalogoEquipoIdSubTipoCatalogo { get; set; }
    public int CatCatalogoEquipoIdUnidad { get; set; }
    public int CatCatalogoEquipoIdImpuesto { get; set; }
    public string CatCatalogoEquipoDescripcion { get; set; } = null!;
    public int Orden { get; set; }
    public int MostrarApi { get; set; }
    public string Unidad { get; set; } = null!;
    public string Multiempresa { get; set; } = null!;
}
