namespace SAMMAI.Transverse.Models.Objects;

public class ViewEquFamiliaFallaObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string FamiliaFalla { get; set; } = null!;
    public int IdFamilia { get; set; }
    public string GenFamiliaFamilia { get; set; } = null!;
    public string? GenFamiliaFamiliaCodigo { get; set; }
    public int GenFamiliaIdFamilia { get; set; }
    public int IdFalla { get; set; }
    public string EquFallaFalla { get; set; } = null!;
    public string? EquFallaFallaCodigo { get; set; }
    public string EquFallaProcedimiento { get; set; } = null!;
    public int EquFallaIdTipoFalla { get; set; }
    public int EquFallaIdFalla { get; set; }
    public string Multiempresa { get; set; } = null!;
}
