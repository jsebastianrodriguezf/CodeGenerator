namespace SAMMAI.Transverse.Models.Objects;

public class ViewSegCargoObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string Cargo { get; set; } = null!;
    public string? CargoCodigo { get; set; }
    public bool? EsTecnico { get; set; }
    public bool? EsComercial { get; set; }
    public bool? EsCoordinador { get; set; }
    public decimal? ValorHora { get; set; }
    public bool EsAdministrativo { get; set; }
    public string Multiempresa { get; set; } = null!;
}
