namespace SAMMAI.Transverse.Models.Objects;

public class ViewSegUsuarioCatalogoEquipoObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string UsuarioCatalogoEquipo { get; set; } = null!;
    public int IdUsuario { get; set; }
    public string SegUsuarioUsuario { get; set; } = null!;
    public string? SegUsuarioUsuarioCodigo { get; set; }
    public int? SegUsuarioIntentosFallidos { get; set; }
    public int? SegUsuarioNumeroIngresos { get; set; }
    public DateTime? SegUsuarioFechaUltimoIngresoFh { get; set; }
    public DateTime? SegUsuarioFechaIntentoFallidoFh { get; set; }
    public string? SegUsuarioClave { get; set; }
    public string? SegUsuarioNombre { get; set; }
    public string? SegUsuarioProfesion { get; set; }
    public string SegUsuarioEmail { get; set; } = null!;
    public string? SegUsuarioDireccion { get; set; }
    public string? SegUsuarioTelefono { get; set; }
    public decimal? SegUsuarioCostoHora { get; set; }
    public double? SegUsuarioPorcentajeComision { get; set; }
    public bool? SegUsuarioAccesoActivo { get; set; }
    public bool? SegUsuarioCambiarClave { get; set; }
    public DateTime? SegUsuarioFechaUltimoCambioClaveFh { get; set; }
    public bool SegUsuarioAplicaRecargo { get; set; }
    public bool SegUsuarioSexo { get; set; }
    public int SegUsuarioIdPerfil { get; set; }
    public int SegUsuarioIdCargo { get; set; }
    public int SegUsuarioIdGrupo { get; set; }
    public int SegUsuarioIdZona { get; set; }
    public string? SegUsuarioIdentificacion { get; set; }
    public int SegUsuarioIdUsuario { get; set; }
    public byte[]? SegUsuarioPreferencias { get; set; }
    public int IdTipoServicio { get; set; }
    public string GenTipoServicioTipoServicio { get; set; } = null!;
    public string? GenTipoServicioTipoServicioCodigo { get; set; }
    public bool? GenTipoServicioTieneGarantia { get; set; }
    public int? GenTipoServicioDiasGarantia { get; set; }
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
    public int CatCatalogoEquipoIdSubtipoCatalogo { get; set; }
    public int CatCatalogoEquipoIdUnidad { get; set; }
    public int CatCatalogoEquipoIdImpuesto { get; set; }
    public string CatCatalogoEquipoDescripcion { get; set; } = null!;
    public bool CatCatalogoEquipoBloquearCostear { get; set; }
    public string Multiempresa { get; set; } = null!;
}
